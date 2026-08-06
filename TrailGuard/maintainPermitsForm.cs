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
    public partial class maintainPermitsForm : Form
    {

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";


        SqlConnection conn;

        //Variable that save the Id of the selected Trail in the data grid view
        private int selectedTrailID;
        public maintainPermitsForm()
        {
            InitializeComponent();
        }

        private void btnCreatePermit_Click(object sender, EventArgs e)
        {
            CreatePermitForm form = new CreatePermitForm();
            form.ShowDialog();

            //Refresh the datagridView
            loadPermits();

        }

        private void maintainPermitsForm_Load(object sender, EventArgs e)
        {
            loadPermits();
            styleDGVPermits();
        }

        //function to style the datagrid view
        private void styleDGVPermits()
        {
            dgvPermits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermits.EnableHeadersVisualStyles = false;
            dgvPermits.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 191, 99);
            dgvPermits.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPermits.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvPermits.RowTemplate.Height = 30;
        }

        private void loadPermits()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = @"SELECT PermitID, TrailID, Date, CheckInTime, ExpectedReturnTime, Status FROM Permit";
                SqlCommand comm = new SqlCommand(sqlQuery, conn);
                DataTable dt = new DataTable();

                adapter.SelectCommand = comm;
                adapter.Fill(dt);
                dgvPermits.DataSource = dt;

                //Load Action columns
                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function that add an actions column with action buttons
        private void AddActionColumn()
        {

            if (dgvPermits.Columns.Contains("Actions"))
            {
                return;
            }

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Actions";
            btnColumn.HeaderText = "Actions";
            btnColumn.Text = "Select Action";
            btnColumn.UseColumnTextForButtonValue = true;

            //default color styling of the action buttons
            btnColumn.DefaultCellStyle.BackColor = Color.FromArgb(6, 71, 96);
            btnColumn.DefaultCellStyle.ForeColor = Color.White;

            dgvPermits.Columns.Add(btnColumn);
        }


        
        private void dgvTrails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPermits();
            txtSearchPark.PlaceholderText = "Search permit by ID...";
        }


        //load the context menu strip named cmsTails with action options based on the Status of the trail in the row of te DGV
        private void dgvPermits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // just return the function if a valid row is not clicked
            if (e.RowIndex < 0)
            {
                return;
            }

            //Return the column clicked is not the actions column
            if (dgvPermits.Columns[e.ColumnIndex].Name != "Actions")
                return;

            // Set the selected Trail ID based on the row's which Actions button is clicked on.
            selectedTrailID = Convert.ToInt32(
                dgvPermits.Rows[e.RowIndex]
                .Cells["PermitID"].Value);

            //Get the status value of each row and convert it to a string
            string status = dgvPermits.Rows[e.RowIndex].Cells["Status"].Value.ToString();


            //Clear the cmsTrailActions before creating a new row menu
            cmsPermitActions.Items.Clear();

            //Create the dropdown menu in cmsTrailActions based on the status to the clicked-on row
            if (status == "Active")
            {
                ToolStripMenuItem setCheckOut = new ToolStripMenuItem("Check-Out");
                setCheckOut.ForeColor = Color.White;
                setCheckOut.BackColor = Color.FromArgb(171, 78, 72);

                cmsPermitActions.Items.Add(setCheckOut);
            }

            if (status == "Registered")
            {
                ToolStripMenuItem setCheckIn = new ToolStripMenuItem("Check-In");
                setCheckIn.ForeColor = Color.White;
                setCheckIn.BackColor = Color.FromArgb(32, 97, 48);

                cmsPermitActions.Items.Add(setCheckIn);

                ToolStripMenuItem setCancel = new ToolStripMenuItem("Cancel");
                setCancel.ForeColor = Color.White;
                setCancel.BackColor = Color.FromArgb(171, 78, 72);

                cmsPermitActions.Items.Add(setCancel);

                ToolStripMenuItem setEdit = new ToolStripMenuItem("Edit");
                setEdit.ForeColor = Color.Black;
                setEdit.BackColor = Color.White;

                cmsPermitActions.Items.Add(setEdit);
            }

            // add the view details option to all regardless of status
            ToolStripMenuItem viewDetails = new ToolStripMenuItem("View Details");
            viewDetails.ForeColor = Color.White;
            viewDetails.BackColor = Color.FromArgb(48, 102, 209);

            cmsPermitActions.Items.Add(viewDetails);


            //Display the menu content strip
            if (cmsPermitActions.Items.Count > 0)
            {
                Rectangle cellRect =
                    dgvPermits.GetCellDisplayRectangle(
                        e.ColumnIndex,
                        e.RowIndex,
                        true);

                cmsPermitActions.Show(
                    dgvPermits,
                    cellRect.Left,
                    cellRect.Bottom);
            }
        }
    }
}
