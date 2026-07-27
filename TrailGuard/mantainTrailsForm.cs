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
    public partial class mantainTrailsForm : Form
    {


        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";


        SqlConnection conn;

        //Variable that save the Id of the selected Trail in the data grid view
        private int selectedTrailID;
        public mantainTrailsForm()
        {
            InitializeComponent();


        }

        private void mantainTrails_Load(object sender, EventArgs e)
        {
            txtSearchTrail.PlaceholderText = "Search a trail...";
            //Load the form data into the data gridview when the form loads
            loadTrails();
            // style the data grid view when the form loads
            styleDGVTrails();
        }

        private void btnCreateTrail_Click(object sender, EventArgs e)
        {
            CreateTrailForm form = new CreateTrailForm();
            form.ShowDialog();
            //Add load data function later to reload the data once the form dialog closes.
        }
        // function that loads the data of the Trails table into the Data Grid View
        private void loadTrails()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = @"SELECT TrailID, ParkID, TrailName, DifficultyLevel, MaximumHikers, Status FROM Trail";
                SqlCommand comm = new SqlCommand(sqlQuery, conn);
                DataTable dt = new DataTable();

                adapter.SelectCommand = comm;
                adapter.Fill(dt);
                dgvTrails.DataSource = dt;

                //Load Action columns
                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function to style the datagrid view
        private void styleDGVTrails()
        {
            dgvTrails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrails.EnableHeadersVisualStyles = false;
            dgvTrails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 191, 99);
            dgvTrails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvTrails.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvTrails.RowTemplate.Height = 30;
        }

        //function that add an actions column with action buttons
        private void AddActionColumn()
        {

            if (dgvTrails.Columns.Contains("Actions"))
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

            dgvTrails.Columns.Add(btnColumn);
        }



        private void btnFilterOpenStatus_Click(object sender, EventArgs e) { }

        private void pnlFormContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //reload all the trail data
            loadTrails();
        }

        //load the context menu strip named cmsTails with action options based on the Status of the trail in the row of te DGV
        private void dgvTrails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // just return the function if a valid row is not clicked
            if (e.RowIndex < 0)
            {
                return;
            }

            //Return the column clicked is not the actions column
            if (dgvTrails.Columns[e.ColumnIndex].Name != "Actions")
                return;

            // Set the selected Trail ID based on the row's which Actions button is clicked on.
            selectedTrailID = Convert.ToInt32(
                dgvTrails.Rows[e.RowIndex]
                .Cells["TrailID"].Value);

            //Get the status value of each row and convert it to a string
            string status = dgvTrails.Rows[e.RowIndex].Cells["Status"].Value.ToString();


            //Clear the cmsTrailActions before creating a new row menu
            cmsTrailActions.Items.Clear();

            //Create the dropdown menu in cmsTrailActions based on the status to the clicked-on row
            if (status == "Open")
            {
                ToolStripMenuItem setClosed = new ToolStripMenuItem("Close");
                setClosed.ForeColor = Color.White;
                setClosed.BackColor = Color.FromArgb(173, 45, 56);

                cmsTrailActions.Items.Add(setClosed);
            }

            if (status == "Closed")
            {
                ToolStripMenuItem setOpen = new ToolStripMenuItem("Open");
                setOpen.ForeColor = Color.White;
                setOpen.BackColor = Color.FromArgb(52, 95, 173);

                cmsTrailActions.Items.Add(setOpen);
            }

            // add the edit option to all regardless of status
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            editItem.ForeColor = Color.Black;
            editItem.BackColor = Color.White;

            cmsTrailActions.Items.Add(editItem);


            //Display the menu content strip
            if (cmsTrailActions.Items.Count > 0)
            {
                Rectangle cellRect =
                    dgvTrails.GetCellDisplayRectangle(
                        e.ColumnIndex,
                        e.RowIndex,
                        true);

                cmsTrailActions.Show(
                    dgvTrails,
                    cellRect.Left,
                    cellRect.Bottom);
            }
        }

        //determine what happens if one of the items in the contextMenuStrip is clicked
        private void cmsTrailActions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cmsTrailActions.Close();

            string action = e.ClickedItem.Text;

            switch (action) {
                case "Edit":
                    EditTrail(selectedTrailID);
                    break;
                case "Close":
                    //reload the datagridview if updated successfully
                    if (closeTrail(selectedTrailID)) {
                        loadTrails();
                    }
                    break;
                case "Open":
                    if (openTrail(selectedTrailID)) {
                        loadTrails();
                    }
                    break;
            }
        }

        //function that opens the edit form to edit a trail
        private void EditTrail( int selectedTrailID) { 
            EditTrailForm form = new EditTrailForm(selectedTrailID);

            if (form.ShowDialog() == DialogResult.OK) {
                loadTrails();
            }
        }
        //function that set the status of a trail to closes
        private bool closeTrail(int selectedTrailID)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                
                string sqlQuery = "UPDATE Trail SET Status = 'Closed' WHERE TrailID = @TrailID";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                cmd.Parameters.AddWithValue("@TrailID", selectedTrailID);
               
                //execute and confirm that it sucessfully updated
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();
                return rowsAffected > 0;
               
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        //function that set the status of a trail to open
        private bool openTrail(int selectedTrailID)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string sqlQuery = @"UPDATE Trail SET Status = 'Open' WHERE TrailID = @TrailID";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                cmd.Parameters.AddWithValue("@TrailID", selectedTrailID);

                //execute and confirm that it sucessfully updated
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();
                return rowsAffected > 0;
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

    }
}
