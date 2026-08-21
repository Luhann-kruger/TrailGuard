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
    public partial class EditHikerForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");

        // Variable that saves the passed-in participant ID
        private int selectedParticipantID;

        // Holds the linked EmergencyContact's ID, loaded from the Participant record
        private int emergencyContactID;

        public EditHikerForm(int participantID)
        {
            InitializeComponent();
            selectedParticipantID = participantID;
        }

        private void EditHikerForm_Load(object sender, EventArgs e)
        {
            // Populate the Relationship ComboBox
            cbRelationship.Items.Clear();
            cbRelationship.Items.Add("Parent");
            cbRelationship.Items.Add("Spouse");
            cbRelationship.Items.Add("Sibling");
            cbRelationship.Items.Add("Child");
            cbRelationship.Items.Add("Friend");
            cbRelationship.Items.Add("Relative");
            cbRelationship.Items.Add("Other");

            LoadParticipantDetails();
        }

        // Load the current Participant's details from the DB using a DataReader and pre-fill the form controls
        private void LoadParticipantDetails()
        {
            if (selectedParticipantID <= 0)
            {
                MessageBox.Show("No Participant was selected to edit.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                conn.Open();

                // SQL joining Participant and EmergencyContact on EmergencyContactID
                SqlCommand command = new SqlCommand(
                    @"SELECT p.FirstName, p.LastName, p.IDNumber, p.PhoneNumber, p.EmailAddress,
                             p.HomeAddress, p.MedicalNotes, p.EmergencyContactID,
                             ec.FirstName AS EmergencyFirstName,
                             ec.PhoneNumber AS EmergencyPhoneNumber,
                             ec.RelationshipToParticipant
                      FROM Participant p
                      LEFT JOIN EmergencyContact ec ON ec.EmergencyContactID = p.EmergencyContactID
                      WHERE p.ParticipantID = @id", conn);
                command.Parameters.AddWithValue("@id", selectedParticipantID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtIDnum.Text = reader["IDNumber"].ToString();
                    txtPhoneNum.Text = reader["PhoneNumber"].ToString();
                    txtEmailAddress.Text = reader["EmailAddress"].ToString();
                    txtHomeAddress.Text = reader["HomeAddress"].ToString();
                    rtxtMedicalNotes.Text = reader["MedicalNotes"].ToString();
                    txtEmergencyFirstName.Text = reader["EmergencyFirstName"].ToString();
                    txtEmergencyPhoneNum.Text = reader["EmergencyPhoneNumber"].ToString();

                    emergencyContactID = Convert.ToInt32(reader["EmergencyContactID"]);

                    // Select the matching relationship in the ComboBox
                    string existingRelationship = reader["RelationshipToParticipant"].ToString();
                    for (int i = 0; i < cbRelationship.Items.Count; i++)
                    {
                        if (cbRelationship.Items[i].ToString() == existingRelationship)
                        {
                            cbRelationship.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Participant not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                reader.Close();
                conn.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Database error: " + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            // ID Number is required and must be exactly 13 digits
            string idNumber = txtIDnum.Text.Trim();
            if (string.IsNullOrWhiteSpace(idNumber))
            {
                MessageBox.Show("ID Number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDnum.Focus();
                return;
            }
            if (idNumber.Length != 13 || !idNumber.All(char.IsDigit))
            {
                MessageBox.Show("ID Number must contain exactly 13 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDnum.Focus();
                return;
            }

            // Phone Number is required and must be exactly 10 digits
            string phoneNumber = txtPhoneNum.Text.Trim();
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNum.Focus();
                return;
            }
            if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Phone Number must contain exactly 10 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNum.Focus();
                return;
            }

            // Validate Email Address (required, basic format check)
            string email = txtEmailAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email Address is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAddress.Focus();
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid Email Address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAddress.Focus();
                return;
            }

            // Validate Home Address
            if (string.IsNullOrWhiteSpace(txtHomeAddress.Text))
            {
                MessageBox.Show("Home Address is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHomeAddress.Focus();
                return;
            }

            // Validate Emergency Contact First Name
            if (string.IsNullOrWhiteSpace(txtEmergencyFirstName.Text))
            {
                MessageBox.Show("Emergency Contact First Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmergencyFirstName.Focus();
                return;
            }

            // Emergency Phone Number is required and must be exactly 10 digits
            string emergencyPhone = txtEmergencyPhoneNum.Text.Trim();
            if (string.IsNullOrWhiteSpace(emergencyPhone))
            {
                MessageBox.Show("Emergency Contact Phone Number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmergencyPhoneNum.Focus();
                return;
            }
            if (emergencyPhone.Length != 10 || !emergencyPhone.All(char.IsDigit))
            {
                MessageBox.Show("Emergency Contact Phone Number must contain exactly 10 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmergencyPhoneNum.Focus();
                return;
            }

            // Validate Relationship
            if (cbRelationship.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Relationship to Participant.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbRelationship.Focus();
                return;
            }

            try
            {
                conn.Open();

                // UPDATE the existing Participant record
                SqlCommand participantCommand = new SqlCommand(
                    @"UPDATE Participant
                    SET FirstName = @firstName,
                    LastName = @lastName,
                    IDNumber = @idNumber,
                    PhoneNumber = @phoneNumber,
                    EmailAddress = @emailAddress,
                    HomeAddress = @homeAddress,
                    MedicalNotes = @medicalNotes
                    WHERE ParticipantID = @id", conn);

                participantCommand.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                participantCommand.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                participantCommand.Parameters.AddWithValue("@idNumber", idNumber);
                participantCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                participantCommand.Parameters.AddWithValue("@emailAddress", email);
                participantCommand.Parameters.AddWithValue("@homeAddress", txtHomeAddress.Text.Trim());
                participantCommand.Parameters.AddWithValue("@medicalNotes", rtxtMedicalNotes.Text.Trim());
                participantCommand.Parameters.AddWithValue("@id", selectedParticipantID);

                participantCommand.ExecuteNonQuery();

                // UPDATE the existing EmergencyContact record
                SqlCommand emergencyCommand = new SqlCommand(
                    @"UPDATE EmergencyContact
                    SET FirstName = @emergencyFirstName,
                    PhoneNumber = @emergencyPhoneNumber,
                    RelationshipToParticipant = @relationship
                    WHERE EmergencyContactID = @emergencyContactId", conn);

                emergencyCommand.Parameters.AddWithValue("@emergencyFirstName", txtEmergencyFirstName.Text.Trim());
                emergencyCommand.Parameters.AddWithValue("@emergencyPhoneNumber", emergencyPhone);
                emergencyCommand.Parameters.AddWithValue("@relationship", cbRelationship.SelectedItem.ToString());
                emergencyCommand.Parameters.AddWithValue("@emergencyContactId", emergencyContactID);

                emergencyCommand.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Participant updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Database error: " + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}