using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TrailGuard
{
    public partial class CreateIncidentReportForm : Form
    {
        private int _permitId = 0;
        // connection string to use in the application
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";
        SqlConnection conn = null;

        public CreateIncidentReportForm(int permitID)
        {
            InitializeComponent();
            // assign permit ID to a variable to use in the form 
            _permitId = permitID;
            

        }

        private void CreateIncidentReportForm_Load(object sender, EventArgs e)
        {
            //txtIncidentDescription.Hint = "Eg... Hikers got lost in the mountains. Has severe asthma allergy";
           // txtActionsToBeTaken.Hint = "Deploy/Inform Rescue Unit ";

            try
            {
                conn = new SqlConnection(connString);
            

                string query = "SELECT Participant.FirstName, Participant.LastName, Participant.MedicalNotes, " +
                    "Trail.TrailName, Permit.ExpectedReturnTime, Permit.[Date] " +
                    "FROM Permit " +
                    "JOIN Permit_Participant ON Permit.PermitID = Permit_Participant.PermitID " +
                    "JOIN Participant ON Permit_Participant.ParticipantID = Participant.ParticipantID " +
                    "JOIN Trail ON Permit.TrailID = Trail.TrailID " +
                    "WHERE Permit.PermitID = " + _permitId;



                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string fullName = reader["FirstName"] + " " + reader["LastName"];
                    lblName.Text = "Name : " + fullName;
                    lblTrailName.Text = "Trail Name : " + reader["TrailName"].ToString();

                    // a variable to contain any medical notes for emphasis 
                    string medicalNotes;

                    // in the database the default value for the notes is null
                    if (reader["MedicalNotes"] == DBNull.Value)
                    {
                        medicalNotes = "None";
                    }
                    else
                    {
                        // if it has text then paste text 
                        medicalNotes = reader["MedicalNotes"].ToString();
                    }
                    // dsplay notes message
                    lblMedicalNotes.Text = "Medical Notes : \n" + medicalNotes;

                    // Timespan represents a length of time 
                    TimeSpan expectedReturn = (TimeSpan)reader["ExpectedReturnTime"];
                    lblExReturnTime.Text = "Expected Return Time : " + expectedReturn.ToString(@"hh\:mm");

                    // the time elapsed accounts for days or hours longer than 24 not just hours in one day 
                    DateTime permitDate = (DateTime)reader["Date"];
                    DateTime expectedReturnDateTime = permitDate.Date + expectedReturn;
                    TimeSpan overdueBy = DateTime.Now - expectedReturnDateTime;

                    // the total number of hours overdue 
                    double hoursOverdue = overdueBy.TotalHours;
                    int wholeHoursOverdue = (int)hoursOverdue;

                    string severityLabel;
                    Color severityColor;

                    // severity changes color relative to the severity of the number of hours elapsed
                    if (hoursOverdue >= 10)
                    {
                        severityLabel = "Critical";
                        severityColor = Color.DarkRed;
                    }
                    else if (hoursOverdue >= 6)
                    {
                        severityLabel = "Severe";
                        severityColor = Color.Red;
                    }
                    else if (hoursOverdue >= 3)
                    {
                        severityLabel = "Concerning";
                        severityColor = Color.DarkOrange;
                    }
                    else
                    {
                        severityLabel = "Minor";
                        severityColor = Color.DarkGreen;
                    }

                    // when a ranger clicks on a single permit he may not know which permit did what or when or how much buy this
                    // gives a visual representation of whats needed where 
                    lblSeverityOfSituation.Text = severityLabel + " : Overdue By " + wholeHoursOverdue + " hours";
                    lblSeverityOfSituation.ForeColor = severityColor;

                }
                else
                {
                    // if there is no data to read
                    lblName.Text = "Name : Not found";
                    lblMedicalNotes.Text = "Medical Notes : N/A";
                    lblTrailName.Text = "Trail Name : N/A";
                    lblExReturnTime.Text = "Expected Return Time : N/A";
                    lblSeverityOfSituation.Text = "Severity : N/A";
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error Occured\n\nDetails: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred while loading this form.\n\nDetails: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                
            }
        }


        private void btnCreateIncidentReport_Click(object sender, EventArgs e)
        {
            // check if a description has been added
            if (string.IsNullOrWhiteSpace(txtIncidentDescription.Text))
            {
                MessageBox.Show(
                    "Please enter a description before submitting.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; 
            }

            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                // check for duplicates if an incident is open or in progress then refuse to creat a new incident 

                SqlCommand duplicateCheckCmd = new SqlCommand("SELECT COUNT(*) FROM IncidentReport " +
                                     "WHERE PermitID = " + _permitId + " AND Status IN ('Open', 'In Progress')", conn);
                int existingUnresolvedReports = (int)duplicateCheckCmd.ExecuteScalar();

                if (existingUnresolvedReports > 0)
                {
                    MessageBox.Show(
                        "An unresolved incident report already exists for this permit.",
                        "Duplicate Report",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    // do not create the incident report 
                    return;
                }

                string description = txtIncidentDescription.Text.Trim();

                string actionTaken;

                // if action taken is blank that is fine the database allows for null values
                if (string.IsNullOrWhiteSpace(txtActionsToBeTaken.Text))
                {
                    actionTaken = "";
                }
                else
                {
                    // if there is any text assign it to the variable 
                    actionTaken = txtActionsToBeTaken.Text.Trim();
                }

                // create a new incident report and save it 
                SqlCommand command = new SqlCommand( "INSERT INTO IncidentReport (PermitID, Description, DateReported, ActionTaken, Status) " +
                               "VALUES (" + _permitId + ", '" + description + "', GETDATE(), '" + actionTaken + "', 'Open')", conn);
                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Incident report created successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not create incident report.\n\nDetails: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n\nDetails: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}