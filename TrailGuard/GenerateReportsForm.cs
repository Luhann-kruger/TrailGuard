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
        private const string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        string query = "";

        public GenerateReportsForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        // A method to resize the columns in the DataGridView
        private void AutoSizeGridColumns(DataGridView grid)
        {
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (column.Width < 90)
                {
                    column.Width = 90;
                }
            }
        }

        // A method to change the headings in the Trail Usage DataGridView
        private void FormatTrailUsageGrid(DataGridView grid)
        {
            grid.Columns["TrailName"].HeaderText = "Trail";
            grid.Columns["TotalPermits"].HeaderText = "Total Permits";
            grid.Columns["OverduePermits"].HeaderText = "Overdue Permits";
            grid.Columns["CapacityUsedPercent"].HeaderText = "Capacity Used (%)";
            grid.Columns["CapacityUsedPercent"].DefaultCellStyle.Format = "N2";
            grid.Columns["OnTimeRate"].HeaderText = "On-Time Rate (%)";
            grid.Columns["OnTimeRate"].DefaultCellStyle.Format = "N2";
            grid.Columns["OverdueRate"].HeaderText = "Overdue Rate (%)";
            grid.Columns["OverdueRate"].DefaultCellStyle.Format = "N2";
            grid.Columns["RecommendedAction"].HeaderText = "Recommended Action";
        }

        // A method to change the headings in the Incident DataGridView
        private void FormatIncidentGrid(DataGridView grid)
        {
            grid.Columns["ParkName"].HeaderText = "Park";
            grid.Columns["TotalIncidents"].HeaderText = "Total Incidents";
            grid.Columns["ClosedIncidents"].HeaderText = "Closed Incidents";
            grid.Columns["OpenIncidents"].HeaderText = "Open Incidents";
        }

        // A method that changes the colour of records that need attention
        private void ColorizeTrailUsageGrid(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                string action = "";

                if (row.Cells["RecommendedAction"].Value != null)
                {
                    action = row.Cells["RecommendedAction"].Value.ToString();
                }

                if (action == "Needs signage or closure review")
                {
                    row.Cells["RecommendedAction"].Style.ForeColor = Color.DarkRed;
                    row.Cells["OverdueRate"].Style.ForeColor = Color.DarkRed;
                }
                else if (action == "Underused: Review promotion or resources")
                {
                    row.Cells["RecommendedAction"].Style.ForeColor = Color.DarkOrange;
                    row.Cells["OnTimeRate"].Style.ForeColor = Color.DarkOrange;
                }
                else
                {
                    row.Cells["RecommendedAction"].Style.ForeColor = Color.SeaGreen;
                }
            }
        }

        // A method that changes the colour of the incident records
        private void ColorizeIncidentGrid(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.Cells["ClosedIncidents"].Style.ForeColor = Color.SeaGreen;
                row.Cells["OpenIncidents"].Style.ForeColor = Color.DarkRed;
            }
        }

        // A method for showing and hiding the summary controls
        private void SetSummaryControlsVisible(bool visible)
        {
            lblMostUsedTrail.Visible = visible;
            lblLeastUsedTrail.Visible = visible;
            lblPeakUsage.Visible = visible;
            label5.Visible = visible;
            label6.Visible = visible;
            label7.Visible = visible;
            pnlUnderusedNotice.Visible = visible;
            pnlSignageNotice.Visible = visible;
        }

        // A method for showing the first report
        // If trailID is null, all trails are shown.
        // If trailID contains an id, only that trail is shown.
        private void RunTrailUsageReport(Nullable<int> trailID, DateTime startDate, DateTime endDate)
        {
            string reportQuery =
                "SELECT dbo.Trail.TrailName, " +
                "COUNT(DISTINCT dbo.Permit.PermitID) AS TotalPermits, " +
                "SUM(CASE WHEN dbo.Permit.Status = 'Overdue' THEN 1 ELSE 0 END) AS OverduePermits, " +
                "CAST(COUNT(dbo.Permit_Participant.ParticipantID) AS FLOAT) " +
                "/ NULLIF(dbo.Trail.MaximumHikers * COUNT(DISTINCT dbo.Permit.PermitID), 0) * 100 AS CapacityUsedPercent, " +
                "CAST(SUM(CASE WHEN dbo.Permit.Status = 'Completed' " +
                "AND dbo.Permit.CheckInTime <= dbo.Permit.ExpectedReturnTime THEN 1 ELSE 0 END) AS FLOAT) " +
                "/ NULLIF(SUM(CASE WHEN dbo.Permit.Status = 'Completed' THEN 1 ELSE 0 END), 0) * 100 AS OnTimeRate, " +
                "CAST(SUM(CASE WHEN dbo.Permit.Status = 'Overdue' THEN 1 ELSE 0 END) AS FLOAT) " +
                "/ NULLIF(COUNT(DISTINCT dbo.Permit.PermitID), 0) * 100 AS OverdueRate " +
                "FROM dbo.Permit " +
                "JOIN dbo.Trail ON dbo.Trail.TrailID = dbo.Permit.TrailID " +
                "LEFT JOIN dbo.Permit_Participant ON dbo.Permit_Participant.PermitID = dbo.Permit.PermitID " +
                "WHERE dbo.Permit.Date BETWEEN @StartDate AND @EndDate ";

            // If a specific trail was selected, add the TrailID to the query
            if (trailID.HasValue)
            {
                reportQuery = reportQuery +
                    "AND dbo.Trail.TrailID = @TrailID ";
            }

            reportQuery = reportQuery +
                "GROUP BY dbo.Trail.TrailName, dbo.Trail.MaximumHikers " +
                "ORDER BY dbo.Trail.TrailName";

            DataTable resultTable = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(reportQuery, conn);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                if (trailID.HasValue)
                {
                    cmd.Parameters.AddWithValue("@TrailID", trailID.Value);
                }

                conn.Open();
                reader = cmd.ExecuteReader();
                resultTable.Load(reader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load report: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            // Add a column for the recommended action
            resultTable.Columns.Add("RecommendedAction", typeof(string));

            int underusedCount = 0;
            int signageCount = 0;

            // Go through each trail in the result
            foreach (DataRow row in resultTable.Rows)
            {
                double onTimeRate;

                if (row["OnTimeRate"] == DBNull.Value)
                {
                    onTimeRate = -1;
                }
                else
                {
                    onTimeRate = Convert.ToDouble(row["OnTimeRate"]);
                }

                double overdueRate;

                if (row["OverdueRate"] == DBNull.Value)
                {
                    overdueRate = 0;
                }
                else
                {
                    overdueRate = Convert.ToDouble(row["OverdueRate"]);
                }

                if (overdueRate > 20)
                {
                    row["RecommendedAction"] = "Needs signage or closure review";
                    signageCount = signageCount + 1;
                }
                else if (onTimeRate >= 0 && onTimeRate < 60)
                {
                    row["RecommendedAction"] = "Underused: Review promotion or resources";
                    underusedCount = underusedCount + 1;
                }
                else
                {
                    row["RecommendedAction"] = "No action needed";
                }
            }

            // Display the number of underused trails
            lblUnderusedNotice.Text =
                underusedCount.ToString() + " trail(s) Underused";

            // Display the number of trails requiring attention
            lblSignageNotice.Text =
                signageCount.ToString() + " trail(s) need Signage or Closure";

            dgvReport.DataSource = resultTable;

            FormatTrailUsageGrid(dgvReport);
            AutoSizeGridColumns(dgvReport);
            ColorizeTrailUsageGrid(dgvReport);
        }

        // A method for showing the second report
        private void RunIncidentSummaryReport(DateTime startDate, DateTime endDate)
        {
            string reportQuery =
                "SELECT dbo.Park.ParkName, " +
                "COUNT(dbo.IncidentReport.IncidentReportID) AS TotalIncidents, " +
                "SUM(CASE WHEN dbo.IncidentReport.Status = 'Closed' THEN 1 ELSE 0 END) AS ClosedIncidents, " +
                "SUM(CASE WHEN dbo.IncidentReport.Status <> 'Closed' THEN 1 ELSE 0 END) AS OpenIncidents " +
                "FROM dbo.IncidentReport " +
                "JOIN dbo.Permit ON dbo.Permit.PermitID = dbo.IncidentReport.PermitID " +
                "JOIN dbo.Trail ON dbo.Trail.TrailID = dbo.Permit.TrailID " +
                "JOIN dbo.Park ON dbo.Park.ParkID = dbo.Trail.ParkID " +
                "WHERE dbo.IncidentReport.DateReported >= @StartDate " +
                "AND dbo.IncidentReport.DateReported < @EndDateExclusive " +
                "GROUP BY dbo.Park.ParkName " +
                "ORDER BY COUNT(dbo.IncidentReport.IncidentReportID) DESC";

            DataTable resultTable = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(reportQuery, conn);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDateExclusive", endDate.Date.AddDays(1));

                conn.Open();
                reader = cmd.ExecuteReader();
                resultTable.Load(reader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load incident report: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            dgvIncidents.DataSource = resultTable;

            FormatIncidentGrid(dgvIncidents);
            AutoSizeGridColumns(dgvIncidents);
            ColorizeIncidentGrid(dgvIncidents);
        }

        // Button used to generate the reports
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePickerSTARTDATE.Value > dateTimePickerENDDATE.Value)
            {
                MessageBox.Show(
                    "Start date cannot be after the end date.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            try
            {
                int trailID = GetSelectedTrailID();

                Nullable<int> trailFilter;

                if (trailID == -1)
                {
                    trailFilter = null;
                }
                else
                {
                    trailFilter = trailID;
                }

                RunTrailUsageReport(
                    trailFilter,
                    dateTimePickerSTARTDATE.Value,
                    dateTimePickerENDDATE.Value);

                RunIncidentSummaryReport(
                    dateTimePickerSTARTDATE.Value,
                    dateTimePickerENDDATE.Value);

                lblMostUsedTrail.Text =
                    GetMostUsedTrail(
                        dateTimePickerSTARTDATE.Value,
                        dateTimePickerENDDATE.Value);

                lblLeastUsedTrail.Text =
                    GetLeastUsedTrail(
                        dateTimePickerSTARTDATE.Value,
                        dateTimePickerENDDATE.Value);

                lblPeakUsage.Text =
                    GetPeakUsageDate(
                        trailID,
                        dateTimePickerSTARTDATE.Value,
                        dateTimePickerENDDATE.Value);

                SetSummaryControlsVisible(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Load the trails into the ComboBox
        private void GenerateReportsForm_Load(object sender, EventArgs e)
        {
            cmbTrails.Items.Clear();
            cmbTrails.Items.Add("All");

            query =
                "SELECT DISTINCT TrailName " +
                "FROM Trail " +
                "ORDER BY TrailName";

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(query, conn);

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbTrails.Items.Add(
                        reader["TrailName"].ToString());
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
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            cmbTrails.SelectedIndex = 0;

            SetSummaryControlsVisible(false);
        }

        // Get the id of the selected trail
        private int GetSelectedTrailID()
        {
            string selectedTrail =
                cmbTrails.SelectedItem.ToString();

            int trailID = -1;

            if (selectedTrail == "All")
            {
                return trailID;
            }

            string lookupQuery =
                "SELECT TrailID " +
                "FROM Trail " +
                "WHERE TrailName = @TrailName";

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(lookupQuery, conn);

                cmd.Parameters.AddWithValue(
                    "@TrailName",
                    selectedTrail);

                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    trailID =
                        Convert.ToInt32(reader["TrailID"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not look up trail: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            return trailID;
        }

        // Get the date with the highest number of permits
        private string GetPeakUsageDate(
            int trailID,
            DateTime startDate,
            DateTime endDate)
        {
            string peakDate = "No data";
            string peakQuery;

            if (trailID == -1)
            {
                peakQuery =
                    "SELECT TOP 1 dbo.Permit.Date, COUNT(*) AS TotalPermits " +
                    "FROM dbo.Permit " +
                    "WHERE dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
                    "GROUP BY dbo.Permit.Date " +
                    "ORDER BY COUNT(*) DESC";
            }
            else
            {
                peakQuery =
                    "SELECT TOP 1 dbo.Permit.Date, COUNT(*) AS TotalPermits " +
                    "FROM dbo.Permit " +
                    "WHERE dbo.Permit.TrailID = @TrailID " +
                    "AND dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
                    "GROUP BY dbo.Permit.Date " +
                    "ORDER BY COUNT(*) DESC";
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(peakQuery, conn);

                if (trailID != -1)
                {
                    cmd.Parameters.AddWithValue("@TrailID", trailID);
                }

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    peakDate =
                        Convert.ToDateTime(reader["Date"]).ToShortDateString() +
                        " (" +
                        reader["TotalPermits"].ToString() +
                        " permits)";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not determine peak usage: " + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            return peakDate;
        }

        // Get the most used trail
        private string GetMostUsedTrail(
            DateTime startDate,
            DateTime endDate)
        {
            return GetExtremeUsedTrail(
                startDate,
                endDate,
                true);
        }

        // Get the least used trail
        private string GetLeastUsedTrail(
            DateTime startDate,
            DateTime endDate)
        {
            return GetExtremeUsedTrail(
                startDate,
                endDate,
                false);
        }

        // Method used to find the most or least used trail
        private string GetExtremeUsedTrail(
            DateTime startDate,
            DateTime endDate,
            bool descending)
        {
            string result = "No data";
            string sortDirection;

            if (descending)
            {
                sortDirection = "DESC";
            }
            else
            {
                sortDirection = "ASC";
            }

            string extremeQuery =
                "SELECT TOP 1 dbo.Trail.TrailName, COUNT(dbo.Permit.PermitID) AS TotalPermits " +
                "FROM dbo.Permit " +
                "INNER JOIN dbo.Trail ON dbo.Permit.TrailID = dbo.Trail.TrailID " +
                "WHERE dbo.Permit.Date BETWEEN @StartDate AND @EndDate " +
                "GROUP BY dbo.Trail.TrailName " +
                "ORDER BY COUNT(dbo.Permit.PermitID) " +
                sortDirection;

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(extremeQuery, conn);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    result =
                        reader["TrailName"].ToString() +
                        " (" +
                        reader["TotalPermits"].ToString() +
                        " permits)";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not determine trail usage: " + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            return result;
        }

        private void cmbTrails_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}