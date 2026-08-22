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


        // report will decide what a critical threshold is for admin information
        private const decimal OVERDUE_RATE_CRITICAL_THRESHOLD = 30m;
        private const decimal OVERDUE_RATE_WARNING_THRESHOLD = 15m;

        // the report check for trails with little to no capacity
        // the report gives recommendations based on metrics set by the administration of the park
        private const decimal CAPACITY_UNDERUSE_THRESHOLD = 20m;
        private const string ACTION_CLOSURE = "Investigate or Consider Closure";
        private const string ACTION_SIGNAGE = "Increase Signage & Patrols";
        private const string ACTION_CAPACITY = "Underused: Review Promotion or Resource Allocation";
        private const string ACTION_NONE = "No Action Needed";

        public GenerateReportsForm()
        {
            InitializeComponent();

        }

       
        private static readonly string[] hiddenColumns = new string[]
        {
            "MaximumHikers",
            "TotalHikers",
            "StillOutPermits",
            "AvgReturnDiffMinutes",
            "AvgGroupSize"
        };

        // after the data grid view has been bound the following method will run
        // it assisgns colors for the critical factors trackecd by the park
        private void dgvReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // hide the columns that are only used to work out other values
            foreach (string columnName in hiddenColumns)
            {
                if (dgvReport.Columns.Contains(columnName))
                {
                    dgvReport.Columns[columnName].Visible = false;
                }
            }

           
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

           // rename colum headings
            if (dgvReport.Columns.Contains("TrailName"))
            {
                dgvReport.Columns["TrailName"].HeaderText = "Trail";
            }

            if (dgvReport.Columns.Contains("TotalPermits"))
            {
                dgvReport.Columns["TotalPermits"].HeaderText = "Total Permits";
            }

            if (dgvReport.Columns.Contains("OverduePermits"))
            {
                dgvReport.Columns["OverduePermits"].HeaderText = "Overdue Permits";
            }

            if (dgvReport.Columns.Contains("CapacityUtilizationPercent"))
            {
                dgvReport.Columns["CapacityUtilizationPercent"].HeaderText = "Capacity Used (%)";
            }

            if (dgvReport.Columns.Contains("OnTimeReturnRatePercent"))
            {
                dgvReport.Columns["OnTimeReturnRatePercent"].HeaderText = "On-Time Rate (%)";
            }

            if (dgvReport.Columns.Contains("OverdueRatePercent"))
            {
                dgvReport.Columns["OverdueRatePercent"].HeaderText = "Overdue Rate (%)";
            }

            if (dgvReport.Columns.Contains("RecommendedAction"))
            {
                dgvReport.Columns["RecommendedAction"].HeaderText = "Recommended Action";
            }

            // if there are no actions the method will not run
            if (!dgvReport.Columns.Contains("RecommendedAction"))
            {
                return;
            }

            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string action;

                if (row.Cells["RecommendedAction"].Value == null)
                {
                    action = "";
                }
                else
                {
                    action = row.Cells["RecommendedAction"].Value.ToString();
                }

                // these colors help administration with a visual importance refrence
                if (action == ACTION_CLOSURE)
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                }
                else if (action == ACTION_SIGNAGE)
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (action == ACTION_CAPACITY)
                {

                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    //normall back color similar to other forms
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
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
                "SUM(CASE WHEN dbo.Permit.CheckInTime IS NULL AND DATEADD(SECOND, DATEDIFF(SECOND, 0, CAST(dbo.Permit.ExpectedReturnTime AS DATETIME)), CAST(dbo.Permit.Date AS DATETIME)) < GETDATE() THEN 1 ELSE 0 END) AS OverduePermits, " +
                "AVG(DATEDIFF(minute, dbo.Permit.ExpectedReturnTime, dbo.Permit.CheckInTime)) AS AvgReturnDiffMinutes, " +
                "CAST(ROUND(CAST(COUNT(dbo.Permit_Participant.ParticipantID) AS DECIMAL(10,2)) / NULLIF(COUNT(DISTINCT dbo.Permit.PermitID), 0), 2) AS DECIMAL(10,2)) AS AvgGroupSize, " +
                "CAST(ROUND(CAST(COUNT(dbo.Permit_Participant.ParticipantID) AS DECIMAL(10,2)) / NULLIF(COUNT(DISTINCT dbo.Permit.PermitID), 0) / NULLIF(dbo.Trail.MaximumHikers, 0) * 100, 2) AS DECIMAL(10,2)) AS CapacityUtilizationPercent, " +
                "CAST(ROUND(CAST(SUM(CASE WHEN dbo.Permit.CheckInTime IS NOT NULL AND dbo.Permit.CheckInTime <= dbo.Permit.ExpectedReturnTime THEN 1 ELSE 0 END) AS DECIMAL(10,2)) / NULLIF(SUM(CASE WHEN dbo.Permit.CheckInTime IS NOT NULL THEN 1 ELSE 0 END), 0) * 100, 2) AS DECIMAL(10,2)) AS OnTimeReturnRatePercent " +
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


                AddDecisionColumns(resultTable);
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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
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
                "SUM(CASE WHEN dbo.Permit.CheckInTime IS NULL AND DATEADD(SECOND, DATEDIFF(SECOND, 0, CAST(dbo.Permit.ExpectedReturnTime AS DATETIME)), CAST(dbo.Permit.Date AS DATETIME)) < GETDATE() THEN 1 ELSE 0 END) AS OverduePermits, " +
                "AVG(DATEDIFF(minute, dbo.Permit.ExpectedReturnTime, dbo.Permit.CheckInTime)) AS AvgReturnDiffMinutes, " +
                "CAST(ROUND(CAST(COUNT(dbo.Permit_Participant.ParticipantID) AS DECIMAL(10,2)) / NULLIF(COUNT(DISTINCT dbo.Permit.PermitID), 0), 2) AS DECIMAL(10,2)) AS AvgGroupSize, " +
                "CAST(ROUND(CAST(COUNT(dbo.Permit_Participant.ParticipantID) AS DECIMAL(10,2)) / NULLIF(COUNT(DISTINCT dbo.Permit.PermitID), 0) / NULLIF(dbo.Trail.MaximumHikers, 0) * 100, 2) AS DECIMAL(10,2)) AS CapacityUtilizationPercent, " +
                "CAST(ROUND(CAST(SUM(CASE WHEN dbo.Permit.CheckInTime IS NOT NULL AND dbo.Permit.CheckInTime <= dbo.Permit.ExpectedReturnTime THEN 1 ELSE 0 END) AS DECIMAL(10,2)) / NULLIF(SUM(CASE WHEN dbo.Permit.CheckInTime IS NOT NULL THEN 1 ELSE 0 END), 0) * 100, 2) AS DECIMAL(10,2)) AS OnTimeReturnRatePercent " +
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

                AddDecisionColumns(resultTable);
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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }

            }

            dgvReport.DataSource = resultTable;
        }

        // this method adds some extra colomns to the report and works out the overdue rate for each trail.
        
        private void AddDecisionColumns(DataTable table)
        {
            // add colomns for report purposes
            table.Columns.Add("OverdueRatePercent", typeof(decimal));
            table.Columns.Add("RecommendedAction", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                int totalPermits;
                if (row["TotalPermits"] == DBNull.Value)
                {
                    totalPermits = 0;
                }
                else
                {
                    totalPermits = Convert.ToInt32(row["TotalPermits"]);
                }

                int overduePermits;
                if (row["OverduePermits"] == DBNull.Value)
                {
                    overduePermits = 0;
                }
                else
                {
                    overduePermits = Convert.ToInt32(row["OverduePermits"]);
                }

                decimal overdueRate;
                if (totalPermits == 0)
                {
                    overdueRate = 0m;
                }
                else
                {
                    overdueRate = Math.Round((decimal)overduePermits / totalPermits * 100m, 1);
                }

                row["OverdueRatePercent"] = overdueRate;

                decimal capacityUtilization;
                if (row["CapacityUtilizationPercent"] == DBNull.Value)
                {
                    capacityUtilization = 0m;
                }
                else
                {
                    capacityUtilization = Convert.ToDecimal(row["CapacityUtilizationPercent"]);
                }


                if (overdueRate >= OVERDUE_RATE_CRITICAL_THRESHOLD)
                {
                    row["RecommendedAction"] = ACTION_CLOSURE;
                }
                else if (overdueRate >= OVERDUE_RATE_WARNING_THRESHOLD)
                {
                    row["RecommendedAction"] = ACTION_SIGNAGE;
                }
                else if (capacityUtilization <= CAPACITY_UNDERUSE_THRESHOLD)
                {
                    row["RecommendedAction"] = ACTION_CAPACITY;
                }
                else
                {
                    row["RecommendedAction"] = ACTION_NONE;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // validate the dates selected
            // End date cannot be before the start date
            if (dateTimePickerSTARTDATE.Value > dateTimePickerENDDATE.Value)
            {
                MessageBox.Show(
                    "Start date cannot be after the end date.",
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

                // get peak usage date
                string peakUsage = GetPeakUsageDate(trailID, dateTimePickerSTARTDATE.Value, dateTimePickerENDDATE.Value);

                lblPeakUsage.Text = peakUsage;
                label7.Visible = true;
                lblPeakUsage.Visible = true;

                // fill in the two alert panels based on what the report just found
                UpdateSummaryPanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // counts how many trails in the current report need attention and
        // updates the two colored panels below the grid with those counts
        private void UpdateSummaryPanels()
        {
            int underusedCount = 0;
            int attentionCount = 0;

            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string action;

                if (row.Cells["RecommendedAction"].Value == null)
                {
                    action = "";
                }
                else
                {
                    action = row.Cells["RecommendedAction"].Value.ToString();
                }

                if (action == ACTION_CAPACITY)
                {
                    underusedCount = underusedCount + 1;
                }

                if (action == ACTION_CLOSURE || action == ACTION_SIGNAGE)
                {
                    attentionCount = attentionCount + 1;
                }
            }

            lblUnderusedCount.Text = underusedCount.ToString() + " trails underused";
            lblAttentionCount.Text = attentionCount.ToString() + " trails need signage or closure";

            //reveal the panels
            pnlUnderused.Visible = true;
            pnlAttention.Visible = true;
        }

        
        private void GenerateReportsForm_Load(object sender, EventArgs e)
        {
            // hide the peak usage caption and value until a report has actually been generated
            pnlUnderused.Visible = false;
            pnlAttention.Visible = false;
            label7.Visible = false;
            lblPeakUsage.Visible = false;

            
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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }

            // default to "All trails"
            cmbTrails.SelectedIndex = 0;
        }

        private int GetSelectedTrailID()
        {
            // guard against SelectedItem being null (e.g. combobox not yet populated)
            if (cmbTrails.SelectedItem == null)
            {
                return -1;
            }

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

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(connString);
                cmd = new SqlCommand(query, conn);

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
                    "Could not determine peak usage date: " + ex.Message,
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


        
       

        private void cmbTrails_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // closes the form when the Close button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}