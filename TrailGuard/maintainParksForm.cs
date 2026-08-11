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
    public partial class maintainParksForm : Form
    {

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";
        SqlConnection conn;

        //variable to store the selected park
        private int selectedParkID;
        public maintainParksForm()
        {
            InitializeComponent();
        }

        private void maintainParksForm_Load(object sender, EventArgs e)
        {
            txtSearchPark.PlaceholderText = "Search a park by name...";

            //call function to load the Park data into the data grid view
            loadParks();
            // style the data grid view when the form loads
            styleDGVParks();
        }

        // function that loads the data of the Parks table into the Data Grid View
        private void loadParks()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = @"SELECT ParkID, ParkName, Province, OfficeNumber FROM Park";
                SqlCommand comm = new SqlCommand(sqlQuery, conn);
                DataTable dt = new DataTable();

                adapter.SelectCommand = comm;
                adapter.Fill(dt);
                dgvParks.DataSource = dt;

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
        private void styleDGVParks()
        {
            dgvParks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParks.EnableHeadersVisualStyles = false;
            dgvParks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 191, 99);
            dgvParks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvParks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvParks.RowTemplate.Height = 30;
        }

        //function that add an actions column with action buttons
        private void AddActionColumn()
        {

            if (dgvParks.Columns.Contains("Action"))
            {
                return;
            }

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Action";
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Edit";
            btnColumn.UseColumnTextForButtonValue = true;

            //default color styling of the action buttons
            btnColumn.DefaultCellStyle.BackColor = Color.FromArgb(6, 71, 96);
            btnColumn.DefaultCellStyle.ForeColor = Color.White;

            dgvParks.Columns.Add(btnColumn);
        }

        private void btnCreatePark_Click(object sender, EventArgs e)
        {
            CreateParkForm form = new CreateParkForm();
            form.ShowDialog();
            loadParks();
        }

        private void dgvParks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            //Return the column clicked is not the actions column
            if (dgvParks.Columns[e.ColumnIndex].Name != "Action")
            {
                return;
            }

            // Set the selected Park ID based on the row's which Actions button is clicked on.
            selectedParkID = Convert.ToInt32(
                dgvParks.Rows[e.RowIndex]
                .Cells["ParkID"].Value);

            //Create a new edit form and pass the selectedParkID
            EditParkForm form = new EditParkForm(selectedParkID);

            //Display the form and also reload the data in dgvParks when the form closes
            form.ShowDialog();
            loadParks();
            

        }

        private void pnlFormContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchString = txtSearchPark.Text.Trim();

                conn = new SqlConnection(connString);
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();

                string sqlQuery = @"SELECT ParkID, ParkName, Province, OfficeNumber FROM Park WHERE ParkName LIKE @search";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchString + "%");

                DataTable dt = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                dgvParks.DataSource = dt;
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
            loadParks();

            txtSearchPark.Text = "";
            txtSearchPark.PlaceholderText = "Search a park by name...";
        }
    }
}
