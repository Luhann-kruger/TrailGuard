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
    public partial class EditParkForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");

        // variable that saves the pass
        private int parkID;

        // paramenter in the constructor to pass the parkID to this form when the edit button on the maintainParksForm is clicked in the dataGridView
        public EditParkForm(int parkID)
        {
            InitializeComponent();
            this.parkID = parkID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditParkForm_Load(object sender, EventArgs e)
        {
            // Populate the Province ComboBox
            comboBoxEditSelectProvince.Items.Clear();
            comboBoxEditSelectProvince.Items.Add("Eastern Cape");
            comboBoxEditSelectProvince.Items.Add("Free State");
            comboBoxEditSelectProvince.Items.Add("Gauteng");
            comboBoxEditSelectProvince.Items.Add("KwaZulu-Natal");
            comboBoxEditSelectProvince.Items.Add("Limpopo");
            comboBoxEditSelectProvince.Items.Add("Mpumalanga");
            comboBoxEditSelectProvince.Items.Add("North West");
            comboBoxEditSelectProvince.Items.Add("Northern Cape");
            comboBoxEditSelectProvince.Items.Add("Western Cape");

            LoadParkDetails();
        }

        // Load the current Park's details from the DB using a DataReader
        // and pre-fill the form controls
        private void LoadParkDetails()
        {
            if (parkID <= 0)
            {
                MessageBox.Show("No Park was selected to edit.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                conn.Open();

                // SQL with WHERE clause
                SqlCommand command = new SqlCommand(
                    @"SELECT ParkName, Province, OfficeNumber
                      FROM Park
                      WHERE ParkID = @id", conn);
                command.Parameters.AddWithValue("@id", parkID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtEditParkName.Text = reader["ParkName"].ToString();

                    // Select the matching province in the ComboBox
                    string existingProvince = reader["Province"].ToString();
                    for (int i = 0; i < comboBoxEditSelectProvince.Items.Count; i++)
                    {
                        if (comboBoxEditSelectProvince.Items[i].ToString() == existingProvince)
                        {
                            comboBoxEditSelectProvince.SelectedIndex = i;
                            break;
                        }
                    }

                    // OfficeNumber from DB
                    txtEditEnterOfficeNumber.Text = reader["OfficeNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("Park not found.", "Error",
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

        private void btnSavePark_Click(object sender, EventArgs e)
        {
            // Validate Park Name
            if (string.IsNullOrWhiteSpace(txtEditParkName.Text))
            {
                MessageBox.Show("Park Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditParkName.Focus();
                return;
            }

            // Validate Province
            if (comboBoxEditSelectProvince.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Province.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxEditSelectProvince.Focus();
                return;
            }

            // Office Number is required and must be exactly 10 digits
            string officeNumber = txtEditEnterOfficeNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(officeNumber))
            {
                MessageBox.Show("Office Number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditEnterOfficeNumber.Focus();
                return;
            }
            if (officeNumber.Length != 10 || !officeNumber.All(char.IsDigit))
            {
                MessageBox.Show("Office Number must contain exactly 10 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditEnterOfficeNumber.Focus();
                return;
            }

            try
            {
                conn.Open();

                // UPDATE the existing Park record
                SqlCommand command = new SqlCommand(
                    @"UPDATE Park
                    SET ParkName = @parkName,
                    Province = @province,
                    OfficeNumber = @officeNumber
                    WHERE ParkID = @id", conn);

                command.Parameters.AddWithValue("@parkName", txtEditParkName.Text.Trim());
                command.Parameters.AddWithValue("@province", comboBoxEditSelectProvince.SelectedItem.ToString());
                command.Parameters.AddWithValue("@officeNumber", officeNumber);
                command.Parameters.AddWithValue("@id", parkID);

                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Park updated successfully!", "Success",
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
    }
}
