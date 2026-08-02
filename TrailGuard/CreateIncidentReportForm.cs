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
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";

        SqlConnection conn;

        //Variable that holds the PermitID that was passed in from the OverduePermitsForm.
        
        private int selectedPermitID;

        public CreateIncidentReportForm(int permitID)
        {
            InitializeComponent();

            //store the foreign key that was passed in so that the insert on this form can use it
            selectedPermitID = permitID;
        }

        private void CreateIncidentReportForm_Load(object sender, EventArgs e)
        {
            //show the ranger which permit this incident report is being logged against
            lblPermitIDValue.Text = selectedPermitID.ToString();
        }

        //function that checks the user input before anything is written to the database
        private bool ValidateIncidentInput()
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a description of the incident.");
                txtDescription.Focus();
                return false;
            }

            if (txtActionTaken.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the actions that will be taken.");
                txtActionTaken.Focus();
                return false;
            }

            return true;
        }

        //function that creates the new record in the IncidentReport table.
       
        private bool saveIncidentReport()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                //the date is formatted as yyyy-MM-dd so that SQL Server reads it the same way every time
                string dateReported = DateTime.Now.ToString("yyyy-MM-dd");

                string sqlQuery = @"INSERT INTO IncidentReport (PermitID, DateReported, Description, ActionTaken, Status) VALUES ("
                    + selectedPermitID + ", '"
                    + dateReported + "', '"
                    + txtDescription.Text.Trim() + "', '"
                    + txtActionTaken.Text.Trim() + "', 'Open')";

                SqlCommand command = new SqlCommand(sqlQuery, conn);

                //execute and confirm that it successfully inserted
                int rowsAffected = command.ExecuteNonQuery();

                conn.Close();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void btnCreateIncidentReport_Click(object sender, EventArgs e)
        {
            //stop here if the user input is not valid
            if (!ValidateIncidentInput())
            {
                return;
            }

            if (saveIncidentReport())
            {
                MessageBox.Show("The incident report was created successfully.");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}