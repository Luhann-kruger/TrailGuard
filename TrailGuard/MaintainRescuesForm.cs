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
    public partial class MaintainRescuesForm : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";

        SqlConnection conn;

        //Variable that saves the Id of the selected Incident Report in the data grid view
        private int selectedIncidentReportID;

        //Variable that saves the PermitID linked to the selected Incident Report,
        //because closing a rescue must also update that permit
        private int selectedPermitID;

        public MaintainRescuesForm()
        {
            InitializeComponent();
        }

        private void MaintainRescuesForm_Load(object sender, EventArgs e)
        {
            txtSearchRescue.PlaceholderText = "Search an incident report...";
            //Load the form data into the data grid view when the form loads
            loadIncidentReports();
            // style the data grid view when the form loads
            styleDataGridViewRescues();
        }

        // function that loads the data of the IncidentReport table into the Data Grid View
        private void loadIncidentReports()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = @"SELECT IncidentReportID, PermitID, DateReported, Description, ActionTaken, Status FROM IncidentReport";
                SqlCommand comm = new SqlCommand(sqlQuery, conn);
                DataTable dataTable = new DataTable();

                adapter.SelectCommand = comm;
                adapter.Fill(dataTable);
                dataGridViewRescues.DataSource = dataTable;

                //Load Action columns
                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function to style the data grid view
        private void styleDataGridViewRescues()
        {
            dataGridViewRescues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRescues.EnableHeadersVisualStyles = false;
            dataGridViewRescues.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 191, 99);
            dataGridViewRescues.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewRescues.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridViewRescues.RowTemplate.Height = 30;
        }

        //function that adds an actions column with action buttons
        private void AddActionColumn()
        {
            if (dataGridViewRescues.Columns.Contains("Action"))
            {
                return;
            }

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Action";
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Select Action";
            btnColumn.UseColumnTextForButtonValue = true;

            //default color styling of the action buttons
            btnColumn.DefaultCellStyle.BackColor = Color.FromArgb(6, 71, 96);
            btnColumn.DefaultCellStyle.ForeColor = Color.White;

            dataGridViewRescues.Columns.Add(btnColumn);
        }

        // Function that filters the data grid view based on the status of the incident report
        private void FilterIncidentReportsByStatus(string incidentStatus)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(@"SELECT IncidentReportID, PermitID, DateReported, Description, ActionTaken, Status FROM IncidentReport WHERE Status = '" + incidentStatus + "'", conn);
                DataTable dataTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(dataTable);
                dataGridViewRescues.DataSource = dataTable;

                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilterOpenStatus_Click(object sender, EventArgs e)
        {
            FilterIncidentReportsByStatus("Open");
        }

        private void btnFilterInProgressStatus_Click(object sender, EventArgs e)
        {
            FilterIncidentReportsByStatus("In Progress");
        }

        private void btnFilterClosedStatus_Click(object sender, EventArgs e)
        {
            FilterIncidentReportsByStatus("Closed");
        }

        //load the context menu strip named cmsRescueActions with action options based on the
        //Status of the incident report in the row of the DataGridView
        private void dataGridViewRescues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // just return the function if a valid row is not clicked
            if (e.RowIndex < 0)
            {
                return;
            }

            //Return if the column clicked is not the actions column
            if (dataGridViewRescues.Columns[e.ColumnIndex].Name != "Action")
            {
                return;
            }

            // Set the selected Incident Report ID based on the row whose Action button is clicked on.
            selectedIncidentReportID = Convert.ToInt32(
                dataGridViewRescues.Rows[e.RowIndex].Cells["IncidentReportID"].Value);

            // Also store the PermitID of that row, it is needed when the rescue is closed
            selectedPermitID = Convert.ToInt32(
                dataGridViewRescues.Rows[e.RowIndex].Cells["PermitID"].Value);

            //Get the status value of the row and convert it to a string
            string status = dataGridViewRescues.Rows[e.RowIndex].Cells["Status"].Value.ToString();

            //Clear the cmsRescueActions before creating a new row menu
            cmsRescueActions.Items.Clear();

            //Create the dropdown menu in cmsRescueActions based on the status of the clicked-on row
            if (status == "Open")
            {
                ToolStripMenuItem launchRescue = new ToolStripMenuItem("Launch Rescue");
                launchRescue.ForeColor = Color.White;
                launchRescue.BackColor = Color.FromArgb(52, 95, 173);

                cmsRescueActions.Items.Add(launchRescue);
            }

            if (status == "In Progress")
            {
                ToolStripMenuItem closeRescue = new ToolStripMenuItem("Close");
                closeRescue.ForeColor = Color.White;
                closeRescue.BackColor = Color.FromArgb(173, 45, 56);

                cmsRescueActions.Items.Add(closeRescue);
            }

            //A report with a status of "Closed" is the end of the state flow, so it has no actions left
            if (cmsRescueActions.Items.Count == 0)
            {
                MessageBox.Show("This incident report is closed, no further actions are available.");
                return;
            }

            //Display the context menu strip
            Rectangle cellRect =
                dataGridViewRescues.GetCellDisplayRectangle(
                    e.ColumnIndex,
                    e.RowIndex,
                    true);

            cmsRescueActions.Show(
                dataGridViewRescues,
                cellRect.Left,
                cellRect.Bottom);
        }

        //determine what happens if one of the items in the contextMenuStrip is clicked
        private void cmsRescueActions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cmsRescueActions.Close();

            string action = e.ClickedItem.Text;

            switch (action)
            {
                case "Launch Rescue":
                    //reload the data grid view if updated successfully
                    if (launchRescue(selectedIncidentReportID))
                    {
                        loadIncidentReports();
                    }
                    break;
                case "Close":
                    if (closeRescue(selectedIncidentReportID, selectedPermitID))
                    {
                        loadIncidentReports();
                    }
                    break;
            }
        }

        //function that moves the incident report from "Open" to "In Progress"
        private bool launchRescue(int selectedIncidentReportID)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string sqlQuery = @"UPDATE IncidentReport SET Status = 'In Progress' WHERE IncidentReportID = " + selectedIncidentReportID;

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                //execute and confirm that it successfully updated
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }


        private bool closeRescue(int selectedIncidentReportID, int selectedPermitID)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmdIncident = new SqlCommand(@"UPDATE IncidentReport SET Status = 'Closed' WHERE IncidentReportID = " + selectedIncidentReportID, conn);

                //execute and confirm that it successfully updated
                int rowsAffected = cmdIncident.ExecuteNonQuery();
                //update permits and not delete, to rescued
                SqlCommand cmdPermit = new SqlCommand(@"UPDATE Permit SET Status = 'Rescued' WHERE PermitID = " + selectedPermitID, conn);

                cmdPermit.ExecuteNonQuery();

                conn.Close();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void pnlFormContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchString = txtSearchRescue.Text.Trim();

                conn = new SqlConnection(connString);
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand(@"SELECT IncidentReportID, PermitID, DateReported, Description, ActionTaken, Status FROM IncidentReport WHERE Description LIKE '%" + searchString + "%' OR ActionTaken LIKE '%" + searchString + "%'", conn);

                DataTable dataTable = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                dataGridViewRescues.DataSource = dataTable;
                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //reload all the incident report data
            loadIncidentReports();

            //Reset the search box
            txtSearchRescue.Text = "";
            txtSearchRescue.PlaceholderText = "Search an incident report...";
        }
    }
}