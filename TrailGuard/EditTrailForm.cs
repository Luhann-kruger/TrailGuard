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
        //Stores the ID of the trail to be editted.
        private int editTrailID;

        //passed the trailID as when the EditTrailForm is opened. Can use this ID to load all the data associated to the trail, make edit and save it to the database. 
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

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                // populate Select Park from the database
                // the user has the option to select another park even though the action button is on a particular park
                SqlDataAdapter parkAdapter = new SqlDataAdapter("SELECT ParkID, ParkName FROM Park", conn);
                DataTable dataTable = new DataTable();
                parkAdapter.Fill(dataTable);
                comboBoxSelectPark.DataSource = dataTable;
                comboBoxSelectPark.DisplayMember = "ParkName";
                comboBoxSelectPark.ValueMember = "ParkID";

                // Load the specific trail's current values
                // this allows the user to see the previous values giving a hint of what to change from
                string trailQuery = "SELECT * FROM Trail WHERE TrailID = " + editTrailID;
                SqlCommand trailCmd = new SqlCommand(trailQuery, conn);
                SqlDataReader reader = trailCmd.ExecuteReader();
                if (reader.Read())
                {
                    txtChangeTrailName.Text = reader["TrailName"].ToString();
                    txtChangeMaximumHikers.Text = reader["MaximumHikers"].ToString();
                    comboBoxSelectPark.SelectedValue = reader["ParkID"];
                    comboBoxSelectDificultyLevel.SelectedItem = reader["DifficultyLevel"].ToString();
                    comboBoxChangeStatus.SelectedItem = reader["Status"].ToString();
                }
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSaveTrail_Click(object sender, EventArgs e)
        {
            // variable to contain the max hikers from the form
            int maxHikers = 0;

            // if the the number in the text box is not a positive integer display a message
            if (!int.TryParse(txtChangeMaximumHikers.Text, out maxHikers))
            {
                MessageBox.Show("Maximum Hikers must be a positive integer .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the user actually wants to go ahead with changes 
            // this is done to ensure no uncertain changes are stored 
            DialogResult confirm = MessageBox.Show("Are you sure you want to update this trail?", "Do you want to update?", MessageBoxButtons.YesNo,
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
                string trailName = txtChangeTrailName.Text.Replace("'", "''");
                string status = comboBoxChangeStatus.SelectedItem.ToString();
                int difficulty = int.Parse(comboBoxChangeStatus.SelectedItem.ToString());
                int parkId = (int)comboBoxSelectPark.SelectedValue;

                string updateQuery = "UPDATE Trail SET " + "TrailName = '" + trailName + "', " + "DifficultyLevel = " + difficulty + ", " +
                    "MaximumHikers = " + maxHikers + ", " + "Status = '" + status + "', " + "ParkID = " + parkId + " " + "WHERE TrailID = " + editTrailID;

                SqlCommand command = new SqlCommand(updateQuery, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("Trail updated successfully.");
            this.Close();
        }

        // if the user decides to save another park directly from the form they can do so
        // the combo box will select a new park and that data will pre appear 
        private void comboBoxSelectPark_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // for parks that have many trails this will also auto update infromtation 
        private void comboBoxSelectTrail_SelectedIndexChanged(object sender, EventArgs e)
        {
            // remeber to autoload trail from the database aswell
        }
    }
}
