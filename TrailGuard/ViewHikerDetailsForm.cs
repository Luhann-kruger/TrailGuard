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
    public partial class ViewHikerDetailsForm : Form
    {


        private int selectedParticipantID;
        SqlConnection conn;
        string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewHikerDetailsForm(int participantID)
        {
            InitializeComponent();
            selectedParticipantID = participantID;
        }

        private void ViewHikerDetailsForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Participant WHERE ParticipantID = @selectedParticipantID";

            try
            {
                conn = new SqlConnection(conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@selectedParticipantID", selectedParticipantID);
                SqlDataReader reader = cmd.ExecuteReader();

                int emergencyContactID = 0;

                if (reader.Read())
                {
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtIDNumber.Text = reader["IDNumber"].ToString();
                    txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                    txtEmailAddress.Text = reader["EmailAddress"].ToString();
                    txtHomeAddress.Text = reader["HomeAddress"].ToString();
                    rtxtMedicalNotes.Text = reader["MedicalNotes"].ToString();
                    emergencyContactID = int.Parse(reader["EmergencyContactID"].ToString());
                }

                reader.Close();

                sql = "SELECT * FROM EmergencyContact WHERE EmergencyContactID = @emergencyContactID";

                SqlCommand ecmd = new SqlCommand(sql, conn);
                ecmd.Parameters.AddWithValue("@emergencyContactID", emergencyContactID);
                SqlDataReader eReader = ecmd.ExecuteReader();

                if (eReader.Read())
                {
                    txtEmergencyName.Text = eReader["FirstName"].ToString();
                    txtEmergencyPhone.Text = eReader["PhoneNumber"].ToString();
                    txtEmergencyRelationship.Text = eReader["RelationshipToParticipant"].ToString();
                }

                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SLQ ERROR: " + ex.Message);
            }
            catch (Exception exx)
            {
                MessageBox.Show("ERROR: " + exx.Message);
            }
            finally { conn.Close(); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlFormContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}