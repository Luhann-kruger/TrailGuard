using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrailGuard
{
    public partial class GenerateReportsForm : Form
    {

        // Declare varibles
        private const string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        string query = "";
        public GenerateReportsForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void RunAllTrailsReport(DateTime startDate, DateTime endDate)
        {
            const string query =
    "SELECT dbo.Trail.TrailName, " +
    "dbo.Trail.MaximumHikers, " +
    "COUNT(DISTINCT dbo.Permit.PermitID) AS TotalPermits, " +
    "COUNT(dbo.Permit_Participant.ParticipantID) AS TotalHikers, " +
    "SUM(CASE WHEN dbo.Permit.CheckInTime IS NULL THEN 1 ELSE 0 END) AS StillOutPermits, " +
    "AVG(DATEDIFF(minute, dbo.Permit.ExpectedReturnTime, dbo.Permit.CheckInTime)) AS AvgReturnDiffMinutes " +
    "FROM dbo.Permit " +
    "JOIN dbo.Trail ON dbo.Trail.TrailID = dbo.Permit.TrailID " +
    "LEFT JOIN dbo.Permit_Participant ON dbo.Permit_Participant.PermitID = dbo.Permit.PermitID " +
    "WHERE dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
    "GROUP BY dbo.Trail.TrailName, dbo.Trail.MaximumHikers";

            DataTable resultTable = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                conn.Open();
                reader = cmd.ExecuteReader();

                resultTable.Load(reader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load report: " + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }

            dgvReport.DataSource = resultTable;
        }

        private void RunSingleTrailReport(int trailID, DateTime startDate, DateTime endDate)
        {
            const string query =
               "SELECT dbo.Trail.TrailName, " +
        "dbo.Trail.MaximumHikers, " +
        "COUNT(DISTINCT dbo.Permit.PermitID) AS TotalPermits, " +
        "COUNT(dbo.Permit_Participant.ParticipantID) AS TotalHikers, " +
        "SUM(CASE WHEN dbo.Permit.CheckInTime IS NULL THEN 1 ELSE 0 END) AS StillOutPermits, " +
        "AVG(DATEDIFF(minute, dbo.Permit.ExpectedReturnTime, dbo.Permit.CheckInTime)) AS AvgReturnDiffMinutes " +
        "FROM dbo.Permit " +
        "JOIN dbo.Trail ON dbo.Trail.TrailID = dbo.Permit.TrailID " +
        "LEFT JOIN dbo.Permit_Participant ON dbo.Permit_Participant.PermitID = dbo.Permit.PermitID " +
        "WHERE dbo.Permit.TrailID = @TrailID AND dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
        "GROUP BY dbo.Trail.TrailName, dbo.Trail.MaximumHikers";

            DataTable resultTable = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TrailID", trailID);
                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                conn.Open();
                reader = cmd.ExecuteReader();

                resultTable.Load(reader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load report: " + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }

            dgvReport.DataSource = resultTable;
        }
        // btn generate report
        private void button1_Click(object sender, EventArgs e)
        {
            // validate the dates selected
            // End date cannot be before the start date

            if (dateTimePickerSTARTDATE.Value > dateTimePickerENDDATE.Value)
            {
                MessageBox.Show("Start date cannot be after the end date.",
                                "Invalid Date",
                                MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            // generate the report
            try
            {
                // get trail ID
                int trailID = GetSelectedTrailID();

                if (trailID == -1)
                {
                    RunAllTrailsReport(dateTimePickerSTARTDATE.Value, dateTimePickerENDDATE.Value);
                }
                else
                {
                    RunSingleTrailReport(trailID, dateTimePickerSTARTDATE.Value, dateTimePickerENDDATE.Value);
                }

                // get the most and least used trails
                string mostUsed = GetMostUsedTrail(dateTimePickerSTARTDATE.Value, dateTimePickerENDDATE.Value);

                string leastUsed = GetLeastUsedTrail(dateTimePickerSTARTDATE.Value, dateTimePickerENDDATE.Value);

                // get peak usage date
                string peakUsage = GetPeakUsageDate(trailID, dateTimePickerSTARTDATE.Value, dateTimePickerENDDATE.Value);
                // display most and least used
                lblMostUsedTrail.Text = mostUsed;
                lblLeastUsedTrail.Text = leastUsed;
                lblPeakUsage.Text = peakUsage;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        // on form load
        private void GenerateReportsForm_Load(object sender, EventArgs e)
        {


            // On form load, populate the items in the combobox with the names of the trails
            cmbTrails.Items.Clear();
            cmbTrails.Items.Add("All");

            // query string to select the trail names
            query = "SELECT DISTINCT TrailName FROM Trail ORDER BY TrailName";

            SqlConnection conn = null;
            SqlCommand cmd;
            SqlDataReader reader = null;

            try
            {
                // connect to the database
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(query, conn);

                conn.Open();
                reader = cmd.ExecuteReader();

                // read the trail names and add them to the combobox
                while (reader.Read())
                {
                    cmbTrails.Items.Add(reader["TrailName"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load trail list: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // close reader and connection
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }

            // default to "All trails"
            cmbTrails.SelectedIndex = 0;

        }


        private int GetSelectedTrailID()
        {
            // get the selected trail name
            string selectedTrail = cmbTrails.SelectedItem.ToString();
            int trailID = -1;

            // check if a specific trail was selected or "all" trails were selected
            if (selectedTrail == "All")
            {
                return trailID;

            }
            else
            {

                const string query = "SELECT TrailID FROM Trail WHERE TrailName = @TrailName";

                SqlConnection conn = null;
                SqlCommand cmd = null;
                SqlDataReader reader = null;


                try
                {
                    conn = new SqlConnection(connString);
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TrailName", selectedTrail);

                    conn.Open();
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        trailID = Convert.ToInt32(reader["TrailID"]);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "Could not look up trail: " + ex.Message,
                        "Database error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null) reader.Close();
                    if (conn != null) conn.Close();
                }

                return trailID;
            }

        }

        private string GetPeakUsageDate(int trailID, DateTime startDate, DateTime endDate)
        {
            string peakDate = "No data";

            string query;

            if (trailID == -1)
            {
                query =
                    "SELECT TOP 1 dbo.Permit.Date, COUNT(*) AS TotalPermits " +
                    "FROM dbo.Permit " +
                    "WHERE dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
                    "GROUP BY dbo.Permit.Date " +
                    "ORDER BY COUNT(*) DESC";
            }
            else
            {
                query =
                    "SELECT TOP 1 dbo.Permit.Date, COUNT(*) AS TotalPermits " +
                    "FROM dbo.Permit " +
                    "WHERE dbo.Permit.TrailID = @TrailID " +
                    "AND dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
                    "GROUP BY dbo.Permit.Date " +
                    "ORDER BY COUNT(*) DESC";
            }

            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (trailID != -1)
                    cmd.Parameters.AddWithValue("@TrailID", trailID);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    peakDate =
                        Convert.ToDateTime(reader["Date"]).ToShortDateString() +
                        " (" +
                        reader["TotalPermits"].ToString() +
                        " permits)";
                }

                reader.Close();
            }

            return peakDate;
        }

        private string GetMostUsedTrail(DateTime startDate, DateTime endDate)
        {
            string mostUsedTrail = "No data";

            const string query =
                "SELECT TOP 1 dbo.Trail.TrailName, " +
                "COUNT(dbo.Permit.PermitID) AS TotalPermits " +
                "FROM dbo.Permit " +
                "INNER JOIN dbo.Trail ON dbo.Permit.TrailID = dbo.Trail.TrailID " +
                "WHERE dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
                "GROUP BY dbo.Trail.TrailName " +
                "ORDER BY COUNT(dbo.Permit.PermitID) DESC";

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mostUsedTrail =
                        reader["TrailName"].ToString() +
                        " (" +
                        reader["TotalPermits"].ToString() +
                        " permits)";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not determine most used trail: " + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }

            return mostUsedTrail;
        }

        private string GetLeastUsedTrail(DateTime startDate, DateTime endDate)
        {
            string leastUsedTrail = "No data";

            const string query =
                "SELECT TOP 1 dbo.Trail.TrailName, " +
                "COUNT(dbo.Permit.PermitID) AS TotalPermits " +
                "FROM dbo.Permit " +
                "INNER JOIN dbo.Trail ON dbo.Permit.TrailID = dbo.Trail.TrailID " +
                "WHERE dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
                "GROUP BY dbo.Trail.TrailName " +
                "ORDER BY COUNT(dbo.Permit.PermitID) ASC";

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    leastUsedTrail =
                        reader["TrailName"].ToString() +
                        " (" +
                        reader["TotalPermits"].ToString() +
                        " permits)";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not determine least used trail: " + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }

            return leastUsedTrail;
        }

        private void cmbTrails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
