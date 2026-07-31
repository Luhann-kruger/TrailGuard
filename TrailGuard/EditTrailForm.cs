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

        // the park this trail belongs to needed for the update
        private int currentParkId;

        // the trail name as it was when the form opened used to report if it changed
        private string originalTrailName = "";

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

                
                string selectQuery = "SELECT Trail.TrailName, Trail.DifficultyLevel, Trail.MaximumHikers, " +
                    "Trail.Status, Trail.ParkID, Park.ParkName " +
                    "FROM Trail INNER JOIN Park ON Trail.ParkID = Park.ParkID " +
                    "WHERE Trail.TrailID = " + editTrailID;

                SqlCommand command = new SqlCommand(selectQuery, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // read only boxes so the user can see what they are editing
                    txtParkName.Text = reader["ParkName"].ToString();
                    txtTrailName.Text = reader["TrailName"].ToString();
                    

                    // the following code controls the display message to confirm name change
                    originalTrailName = reader["TrailName"].ToString();
                    currentParkId = int.Parse(reader["ParkID"].ToString());

                    // show admin a a prieview of whats saved or to be saved
                    txtChangeMaximumHikers.Text = reader["MaximumHikers"].ToString();
                    comboBoxSelectDificultyLevel.SelectedItem = reader["DifficultyLevel"].ToString();
                    comboBoxChangeStatus.SelectedItem = reader["Status"].ToString();
                    txtChangeTrailName.Text = txtTrailName.Text;
                }
                else
                {
                    // there is no trailID found
                    MessageBox.Show("Trail not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSaveTrail.Enabled = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtChangeMaximumHikers.Focus();
                return;
            }
            // if number is less than zero, also show an error 
            if(maxHikers < 0){
                 MessageBox.Show("Maximum Hikers must be greater than zero .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChangeMaximumHikers.Focus();
                return;
            }

            // if there is nothing in the text box for the name display an error message 

            if (txtChangeTrailName.Text.Trim() == "" || txtChangeTrailName.Text.Trim() == "Change Trail Name")
            {
                MessageBox.Show("Please enter a trail name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChangeTrailName.Focus();
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

            // fixes sql bug that sees the ' as pauses
            string trailName = txtChangeTrailName.Text.Trim().Replace("'", "''");

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                string status = comboBoxChangeStatus.SelectedItem.ToString();
                int difficulty = int.Parse(comboBoxSelectDificultyLevel.SelectedItem.ToString());

               // the update query for the form using the currentID to prevent the user from touching another park 
                string updateQuery = "UPDATE Trail SET " + "TrailName = '" + trailName + "', " +
                    "DifficultyLevel = " + difficulty + ", " + "MaximumHikers = " + maxHikers + ", " +
                    "Status = '" + status + "', " + "ParkID = " + currentParkId + " " +
                    "WHERE TrailID = " + editTrailID;

                SqlCommand command = new SqlCommand(updateQuery, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                conn.Close();
            }

            if (txtChangeTrailName.Text.Trim() == originalTrailName)
            {
                MessageBox.Show("Trail updated. Trail name not changed.");
            }
            else
            {
                MessageBox.Show("Trail updated. Trail name changed from '" + originalTrailName + "' to '" + txtChangeTrailName.Text.Trim() + "'.");
            }

            this.Close();
        }

       
    }
}
