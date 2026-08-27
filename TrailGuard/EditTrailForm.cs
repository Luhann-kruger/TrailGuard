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
    public partial class EditTrailForm : Form
    {
        // Stores the ID of the trail to be edited.
        private int editTrailID;

        // a check to ensure that if the form is loading nothing changes similar to a website
        private bool isLoadingForm = false;

        // passed the trailID when the EditTrailForm is opened.
        // Can use this ID to load all the data associated to the trail,
        // make edits and save it to the database.
        public EditTrailForm(int editTrailID)
        {
            InitializeComponent();
            this.editTrailID = editTrailID;
        }

        // connection string for the form
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditTrailForm_Load(object sender, EventArgs e)
        {
            int originalTrailId = editTrailID;
            int loadedParkId = 0;
            bool trailFound = false;

            // this boolean fixes the page load bug.
            // if the page is loading other event handlers won't load,
            // specifically for the comboboxes
            isLoadingForm = true;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                // populate Select Park from the database
                // the user has the option to select another park
                // even though the action button is on a particular park
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "SELECT ParkID, ParkName FROM Park",
                    conn);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                comboBoxSelectPark.DisplayMember = "ParkName";
                comboBoxSelectPark.ValueMember = "ParkID";
                comboBoxSelectPark.DataSource = dataTable;

                // Load the specific trail's current values
                // this allows the user to see the previous values
                // giving a hint of what to change from
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Trail WHERE TrailID = @TrailID",
                    conn);

                // add the trail ID as a parameter
                command.Parameters.AddWithValue("@TrailID", editTrailID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // this controls the loading of the trails
                    trailFound = true;

                    txtChangeTrailName.Text = reader["TrailName"].ToString();
                    txtChangeMaximumHikers.Text = reader["MaximumHikers"].ToString();

                    loadedParkId = int.Parse(reader["ParkID"].ToString());

                    comboBoxSelectDificultyLevel.SelectedItem =
                        reader["DifficultyLevel"].ToString();

                    comboBoxChangeStatus.SelectedItem =
                        reader["Status"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            isLoadingForm = false;

            if (trailFound)
            {
                comboBoxSelectPark.SelectedValue = loadedParkId;

                LoadTrailsForPark(loadedParkId);

                comboBoxSelectTrail.SelectedValue = originalTrailId;

                editTrailID = originalTrailId;
            }
        }

        private void btnSaveTrail_Click(object sender, EventArgs e)
        {
            // variable to contain the max hikers from the form
            int maxHikers = 0;

            // if the number in the text box is not a positive integer
            // display a message
            if (!int.TryParse(txtChangeMaximumHikers.Text, out maxHikers))
            {
                MessageBox.Show(
                    "Maximum Hikers must be a positive integer.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // check if the user actually wants to go ahead with changes
            // this is done to ensure no uncertain changes are stored
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this trail?",
                "Do you want to update?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                // nothing is saved
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string trailName = txtChangeTrailName.Text.Trim();

                string status = comboBoxChangeStatus.SelectedItem.ToString();

                // had a logic error here was reading from the wrong text box
                int difficulty =
                    int.Parse(comboBoxSelectDificultyLevel.SelectedItem.ToString());

                int parkId = (int)comboBoxSelectPark.SelectedValue;

                // update the trail information in the database
                // parameters are used so user input is not directly added to SQL
                string updateQuery =
                    "UPDATE Trail SET " +
                    "TrailName = @TrailName, " +
                    "DifficultyLevel = @DifficultyLevel, " +
                    "MaximumHikers = @MaximumHikers, " +
                    "Status = @Status, " +
                    "ParkID = @ParkID " +
                    "WHERE TrailID = @TrailID";

                SqlCommand command = new SqlCommand(updateQuery, conn);

                // add the values as parameters
                command.Parameters.AddWithValue("@TrailName", trailName);
                command.Parameters.AddWithValue("@DifficultyLevel", difficulty);
                command.Parameters.AddWithValue("@MaximumHikers", maxHikers);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@ParkID", parkId);
                command.Parameters.AddWithValue("@TrailID", editTrailID);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show(
                "Trail updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        // if the user decides to save another park directly from the form
        // they can do so. The combo box will select a new park
        // and that data will appear
        private void comboBoxSelectPark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingForm)
            {
                return;
            }

            if (comboBoxSelectPark.SelectedValue == null)
            {
                return;
            }

            int parkId = (int)comboBoxSelectPark.SelectedValue;

            LoadTrailsForPark(parkId);
        }

        // for parks that have many trails this will also auto update information
        private void comboBoxSelectTrail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingForm)
            {
                return;
            }

            // auto load trail from the database as well
            if (comboBoxSelectTrail.SelectedValue == null)
            {
                return;
            }

            int trailId = (int)comboBoxSelectTrail.SelectedValue;

            editTrailID = trailId;

            LoadTrailDetails(trailId);
        }

        private void LoadTrailsForPark(int parkId)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "SELECT TrailID, TrailName FROM Trail WHERE ParkID = @ParkID",
                    conn);

                // add the park ID as a parameter
                dataAdapter.SelectCommand.Parameters.AddWithValue(
                    "@ParkID",
                    parkId);

                DataTable dataTableTrail = new DataTable();

                dataAdapter.Fill(dataTableTrail);

                comboBoxSelectTrail.DisplayMember = "TrailName";
                comboBoxSelectTrail.ValueMember = "TrailID";
                comboBoxSelectTrail.DataSource = dataTableTrail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // a method to load trail details for the park
        // as a park can have many trails
        private void LoadTrailDetails(int trailId)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Trail WHERE TrailID = @TrailID",
                    conn);

                // add the trail ID as a parameter
                command.Parameters.AddWithValue("@TrailID", trailId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtChangeTrailName.Text =
                        reader["TrailName"].ToString();

                    txtChangeMaximumHikers.Text =
                        reader["MaximumHikers"].ToString();

                    comboBoxSelectDificultyLevel.SelectedItem =
                        reader["DifficultyLevel"].ToString();

                    comboBoxChangeStatus.SelectedItem =
                        reader["Status"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
