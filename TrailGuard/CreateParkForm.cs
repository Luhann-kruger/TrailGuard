using Microsoft.Data.SqlClient;
using System;
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
    public partial class CreateParkForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");

        public CreateParkForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSelectPark_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterOfficeNumber_Click(object sender, EventArgs e)
        {

        }

        private void CreateParkForm_Load(object sender, EventArgs e)
        {
            // Populate the Province ComboBox
            comboBoxSelectProvince.Items.Clear();
            comboBoxSelectProvince.Items.Add("Eastern Cape");
            comboBoxSelectProvince.Items.Add("Free State");
            comboBoxSelectProvince.Items.Add("Gauteng");
            comboBoxSelectProvince.Items.Add("KwaZulu-Natal");
            comboBoxSelectProvince.Items.Add("Limpopo");
            comboBoxSelectProvince.Items.Add("Mpumalanga");
            comboBoxSelectProvince.Items.Add("North West");
            comboBoxSelectProvince.Items.Add("Northern Cape");
            comboBoxSelectProvince.Items.Add("Western Cape");
            comboBoxSelectProvince.SelectedIndex = -1;
        }

        private void btnCreatePark_Click(object sender, EventArgs e)
        {
            // Validate Park Name
            if (string.IsNullOrWhiteSpace(txtEnterParkName.Text))
            {
                MessageBox.Show("Park Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnterParkName.Focus();
                return;
            }

            // Validate Province
            if (comboBoxSelectProvince.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Province.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxSelectProvince.Focus();
                return;
            }

            // Validate Office Number (10 digits)
            string officeNumber = txtEnterOfficeNumber.Text.Trim();
            if (!string.IsNullOrWhiteSpace(officeNumber) && !officeNumber.All(char.IsDigit))
            {
                MessageBox.Show("Office Number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnterOfficeNumber.Focus();
                return;
            }

            if (officeNumber.Length != 10 || !officeNumber.All(char.IsDigit))
            {
                MessageBox.Show("Office Number must contain exactly 10 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnterOfficeNumber.Focus();
                return;
            }

            try
            {
                conn.Open();

                // INSERT new Park record
                SqlCommand command = new SqlCommand(
                    @"INSERT INTO Park (ParkName, Province, OfficeNumber)
                      VALUES (@parkName, @province, @officeNumber)", conn);

                command.Parameters.AddWithValue("@parkName", txtEnterParkName.Text.Trim());

                if (comboBoxSelectProvince.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Province.");
                    return;
                }
                else
                { 
                    command.Parameters.AddWithValue("@province", comboBoxSelectProvince.SelectedItem.ToString());
                }

                command.Parameters.AddWithValue("@officeNumber", officeNumber);

                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Park created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields after save, ready for the next entry
                txtEnterParkName.Text = "";
                comboBoxSelectProvince.SelectedIndex = -1;
                txtEnterOfficeNumber.Text = "";
                txtEnterParkName.Focus();
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
