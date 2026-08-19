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
    public partial class AddHikerForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");

        public AddHikerForm()
        {
            InitializeComponent();
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

            // Validate ID Number (13 digits)
            string idNumber = txtIDnum.Text.Trim();
            if (string.IsNullOrWhiteSpace(idNumber) || !idNumber.All(char.IsDigit))
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

            // Validate Phone Number (10 digits)
            string phoneNumber = txtPhoneNum.Text.Trim();
            if (string.IsNullOrWhiteSpace(phoneNumber) || !phoneNumber.All(char.IsDigit))
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

            // Validate Email Address
            string emailAddress = txtEmailAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                MessageBox.Show("Email Address is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAddress.Focus();
                return;
            }

            if (!emailAddress.Contains("@"))
            {
                MessageBox.Show("Email Address must contain '@'.", "Validation Error",
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

            // Validate Emergency Contact Phone Number (10 digits)
            string emergencyPhoneNumber = txtEmergencyPhoneNum.Text.Trim();
            if (string.IsNullOrWhiteSpace(emergencyPhoneNumber) || !emergencyPhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Emergency Contact Phone Number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmergencyPhoneNum.Focus();
                return;
            }

            if (emergencyPhoneNumber.Length != 10 || !emergencyPhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Emergency Contact Phone Number must contain exactly 10 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmergencyPhoneNum.Focus();
                return;
            }

            // Validate Relationship
            if (cbRelationship.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Relationship to the Participant.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbRelationship.Focus();
                return;
            }

            try
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // INSERT new EmergencyContact record first
                    SqlCommand emergencyCommand = new SqlCommand(
                        @"INSERT INTO EmergencyContact (FirstName, PhoneNumber, RelationshipToParticipant)
                          OUTPUT INSERTED.EmergencyContactID
                          VALUES (@firstName, @phoneNumber, @relationship)", conn, transaction);

                    emergencyCommand.Parameters.AddWithValue("@firstName", txtEmergencyFirstName.Text.Trim());
                    emergencyCommand.Parameters.AddWithValue("@phoneNumber", emergencyPhoneNumber);
                    emergencyCommand.Parameters.AddWithValue("@relationship", cbRelationship.SelectedItem.ToString());

                    int newEmergencyContactId = (int)emergencyCommand.ExecuteScalar();

                    // INSERT new Participant record, linked via EmergencyContactID
                    SqlCommand participantCommand = new SqlCommand(
                        @"INSERT INTO Participant (FirstName, LastName, IDNumber, PhoneNumber, EmailAddress,
                                                     HomeAddress, MedicalNotes, EmergencyContactID)
                          VALUES (@firstName, @lastName, @idNumber, @phoneNumber, @emailAddress,
                                  @homeAddress, @medicalNotes, @emergencyContactId)", conn, transaction);

                    participantCommand.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                    participantCommand.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                    participantCommand.Parameters.AddWithValue("@idNumber", idNumber);
                    participantCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    participantCommand.Parameters.AddWithValue("@emailAddress", emailAddress);
                    participantCommand.Parameters.AddWithValue("@homeAddress", txtHomeAddress.Text.Trim());

                    if (string.IsNullOrWhiteSpace(rtxtMedicalNotes.Text))
                        participantCommand.Parameters.AddWithValue("@medicalNotes", DBNull.Value);
                    else
                        participantCommand.Parameters.AddWithValue("@medicalNotes", rtxtMedicalNotes.Text.Trim());

                    participantCommand.Parameters.AddWithValue("@emergencyContactId", newEmergencyContactId);

                    participantCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    conn.Close();
                }

                MessageBox.Show("Hiker added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields after save, ready for the next entry
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtIDnum.Text = "";
                txtPhoneNum.Text = "";
                txtEmailAddress.Text = "";
                txtHomeAddress.Text = "";
                rtxtMedicalNotes.Text = "";
                txtEmergencyFirstName.Text = "";
                txtEmergencyPhoneNum.Text = "";
                cbRelationship.SelectedIndex = -1;
                txtFirstName.Focus();
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

        private void pnlFormContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddHikerForm_Load(object sender, EventArgs e)
        {
            // Populate the Relationship ComboBox
            cbRelationship.Items.Clear();
            cbRelationship.Items.Add("Parent");
            cbRelationship.Items.Add("Spouse");
            cbRelationship.Items.Add("Sibling");
            cbRelationship.Items.Add("Child");
            cbRelationship.Items.Add("Friend");
            cbRelationship.Items.Add("Other");
            cbRelationship.SelectedIndex = -1;
        }
    }
}