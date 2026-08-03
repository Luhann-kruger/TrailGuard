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
using System.Data.SqlClient;

namespace TrailGuard
{
    public partial class CreateTrailForm : Form
    {
        string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        SqlConnection conn;
        public CreateTrailForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateTrailForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT ParkName FROM Park";

            try
            {
                conn = new SqlConnection(conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cmbSelectPark.Items.Clear();

                bool hasRows = reader.HasRows;

                if (hasRows)
                {
                    while (reader.Read())
                    {
                        cmbSelectPark.Items.Add(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("No parks found. Something went wrong", "No Parks Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

        }

        private void btnCreateTrail_Click(object sender, EventArgs e)
        {
            string parkName = cmbSelectPark.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(parkName))
            {
                MessageBox.Show("Please enter a valid park name.", "No Park Name Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trailName = txtTrailName.Text;

            if (string.IsNullOrEmpty(trailName))
            {
                MessageBox.Show("Please enter a trail name.", "No Park Trail Name Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int difficultyLevel = (int)numDifficultyLevel.Value;

            int maxHikers = (int)numMaxHikers.Value;

            if (maxHikers <= 0)
            {
                MessageBox.Show("Please enter a valid number of hikers.", "Invalid Number of Hikers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateTrail(parkName, trailName, difficultyLevel, maxHikers);

        }

        private void CreateTrail(string parkName, string trailName, int difficultyLevel, int maxHikers)
        {
            string findParkIdSql = @"SELECT ParkID FROM Park WHERE ParkName = @ParkName";

            string insertTrailSql = @"INSERT INTO Trail (ParkID, TrailName, DifficultyLevel, MaximumHikers, Status) 
                            VALUES (@ParkID, @TrailName, @DifficultyLevel, @MaximumHikers, @Status)";
            try
            {
                conn.Open();

                SqlCommand findParkIdCmd = new SqlCommand(findParkIdSql, conn);
                findParkIdCmd.Parameters.AddWithValue("@ParkName", parkName);

                object result = findParkIdCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Could not find a matching park. Please try again.", "Park Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }

                int parkId = (int)result;

                SqlCommand insertTrailCmd = new SqlCommand(insertTrailSql, conn);

                insertTrailCmd.Parameters.AddWithValue("@ParkID", parkId);
                insertTrailCmd.Parameters.AddWithValue("@TrailName", trailName);
                insertTrailCmd.Parameters.AddWithValue("@DifficultyLevel", difficultyLevel);
                insertTrailCmd.Parameters.AddWithValue("@MaximumHikers", maxHikers);
                insertTrailCmd.Parameters.AddWithValue("@Status", "Open");

                int rowsAffected = insertTrailCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Trail added successfully!");
                    this.Close();
                }

                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

        }

        private void lblDifficulty_Click(object sender, EventArgs e)
        {

        }
    }
}
