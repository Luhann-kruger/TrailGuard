using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrailGuard
{
    public partial class viewDetailsForm : Form
    {
        int selectedPermitID;
        // Declare varibles
        private const string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public viewDetailsForm(int selectedPermitID)
        {
            InitializeComponent();
            this.selectedPermitID = selectedPermitID;
        }

        private void viewDetailsForm_Load(object sender, EventArgs e)
        {
            // load the permit and participants information
            LoadPermitInfo();
            LoadParticipants();
        }

        

        private void LoadPermitInfo()
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // select appropriate columns from permit
            cmd.CommandText = @"SELECT TrailID,  Date, CheckInTime, ExpectedReturnTime, Status
                                 FROM Permit
                                 WHERE PermitID = @PermitID";
            cmd.Parameters.AddWithValue("@PermitID", selectedPermitID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                // display the permit details into labels
                if (reader.Read())
                {
                    lblTrail.Text = reader["TrailID"].ToString();
                    lblStatus.Text = reader["Status"].ToString();
                    lblDate.Text = Convert.ToDateTime(reader["Date"]).ToString("yyyy/MM/dd");
                    lblCheckInTime.Text = reader["CheckInTime"] == DBNull.Value
                        ? "-" : ((TimeSpan)reader["CheckInTime"]).ToString(@"hh\:mm\:ss");

                    lblExpectedReturn.Text = reader["ExpectedReturnTime"] == DBNull.Value
                        ? "-" : ((TimeSpan)reader["ExpectedReturnTime"]).ToString(@"hh\:mm\:ss");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load permit info: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadParticipants()
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // select participant information
            cmd.CommandText = @"SELECT p.ParticipantID, p.FirstName, p.LastName, p.IDNumber,
                                        p.PhoneNumber, p.EmailAddress, p.HomeAddress,
                                        p.MedicalNotes, p.EmergencyContactID
                                 FROM Permit_Participant pp
                                 INNER JOIN Participant p ON pp.ParticipantID = p.ParticipantID
                                 WHERE pp.PermitID = @PermitID";
            cmd.Parameters.AddWithValue("@PermitID", selectedPermitID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                dgvParticipants.DataSource = dt;

                // Hide columns we don't want to show as grid columns
                if (dgvParticipants.Columns.Contains("ParticipantID"))
                    dgvParticipants.Columns["ParticipantID"].Visible = false;
                if (dgvParticipants.Columns.Contains("HomeAddress"))
                    dgvParticipants.Columns["HomeAddress"].Visible = false;
                if (dgvParticipants.Columns.Contains("MedicalNotes"))
                    dgvParticipants.Columns["MedicalNotes"].Visible = false;
                if (dgvParticipants.Columns.Contains("EmergencyContactID"))
                    dgvParticipants.Columns["EmergencyContactID"].Visible = false;

                dgvParticipants.ClearSelection();

                // Auto-select the first participant so the detail panel isn't empty
                if (dgvParticipants.Rows.Count > 0)
                {
                    dgvParticipants.Rows[0].Selected = true;
                    ShowParticipantDetail(dgvParticipants.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load participants: " + ex.Message);
            }
        }

        private void dgvParticipants_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvParticipants.SelectedRows.Count > 0)
            {
                ShowParticipantDetail(dgvParticipants.SelectedRows[0]);
            }
        }

        private void ShowParticipantDetail(DataGridViewRow row)
        {
            // show the details of the selected participant from the datagrid view
            // Check for null values
            lblName.Text = row.Cells["FirstName"].Value + " " + row.Cells["LastName"].Value;
            lblEmail.Text = row.Cells["EmailAddress"].Value == DBNull.Value
                ? "-" : row.Cells["EmailAddress"].Value.ToString();
            lblHomeAddress.Text = row.Cells["HomeAddress"].Value == DBNull.Value
                ? "-" : row.Cells["HomeAddress"].Value.ToString();
            lblMedicalNotes.Text = row.Cells["MedicalNotes"].Value == DBNull.Value
                ? "-" : row.Cells["MedicalNotes"].Value.ToString();

            object emergencyContactID = row.Cells["EmergencyContactID"].Value;
            lblEmergencyContact.Text = emergencyContactID == DBNull.Value
                ? "-" : LoadEmergencyContactName(Convert.ToInt32(emergencyContactID));
        }

        private string LoadEmergencyContactName(int emergencyContactID)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // select the emergency contact details
            cmd.CommandText = @"SELECT FirstName, PhoneNumber, RelationshipToParticipant
                                 FROM EmergencyContact
                                 WHERE EmergencyContactID = @EmergencyContactID";
            cmd.Parameters.AddWithValue("@EmergencyContactID", emergencyContactID);

            string result = "-";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // build the string to be displayed
                    result = reader["FirstName"] + " ( " + reader["RelationshipToParticipant"] + ")" + "\n(" + reader["PhoneNumber"] + ")";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load emergency contact: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        private void lblMedicalNotes_Click(object sender, EventArgs e)
        {

        }

        //private void dgvParticipants_SelectionChanged_1(object sender, EventArgs e)
        //{

        //}
    }
}
