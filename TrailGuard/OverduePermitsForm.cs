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
    public partial class OverduePermitsForm : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";

        SqlConnection conn;

        private int selectedPermitID;

        public OverduePermitsForm()
        {
            InitializeComponent();
        }

        private void OverduePermitsForm_Load(object sender, EventArgs e)
        {
            txtSearchPermit.PlaceholderText = "Search an overdue permit by ID...";
            loadOverduePermits();
            styleDataGridViewOverduePermits();
        }

        private void loadOverduePermits()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(@"SELECT PermitID, TrailID, CheckInTime, ExpectedReturnTime, Date, Status FROM Permit WHERE CAST(Date AS DATETIME) + CAST(ExpectedReturnTime AS DATETIME) < GETDATE() AND Status = 'Active'", conn);
                DataTable dataTable = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                dataGridViewOverduePermits.DataSource = dataTable;

                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void styleDataGridViewOverduePermits()
        {
            dataGridViewOverduePermits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOverduePermits.EnableHeadersVisualStyles = false;
            dataGridViewOverduePermits.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 191, 99);
            dataGridViewOverduePermits.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewOverduePermits.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridViewOverduePermits.RowTemplate.Height = 30;

            // give ExpectedReturnTime more breathing room
            dataGridViewOverduePermits.Columns["ExpectedReturnTime"].FillWeight = 180;
        }

        private void AddActionColumn()
        {
            if (dataGridViewOverduePermits.Columns.Contains("Action"))
            {
                return;
            }

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Action";
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Log Incident";
            btnColumn.UseColumnTextForButtonValue = true;

            btnColumn.DefaultCellStyle.BackColor = Color.FromArgb(6, 71, 96);
            btnColumn.DefaultCellStyle.ForeColor = Color.White;

            dataGridViewOverduePermits.Columns.Add(btnColumn);
        }

        private void dataGridViewOverduePermits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridViewOverduePermits.Columns[e.ColumnIndex].Name != "Action")
            {
                return;
            }

            selectedPermitID = Convert.ToInt32(
                dataGridViewOverduePermits.Rows[e.RowIndex].Cells["PermitID"].Value);

            CreateIncidentReportForm form = new CreateIncidentReportForm(selectedPermitID);

            form.ShowDialog();
            loadOverduePermits();
        }

        private void pnlFormContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchString = txtSearchPermit.Text.Trim();

                conn = new SqlConnection(connString);
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand(@"SELECT PermitID, TrailID, CheckInTime, ExpectedReturnTime, Date, Status FROM Permit WHERE CAST(Date AS DATETIME) + CAST(ExpectedReturnTime AS DATETIME) < GETDATE() AND Status = 'Active' AND CAST(PermitID AS VARCHAR) LIKE '%" + searchString + "%'", conn);

                DataTable dataTable = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                dataGridViewOverduePermits.DataSource = dataTable;
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
            loadOverduePermits();

            txtSearchPermit.Text = "";
            txtSearchPermit.PlaceholderText = "Search an overdue permit by ID...";
        }
    }
}