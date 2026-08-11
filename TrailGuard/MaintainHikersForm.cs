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
    public partial class MaintainHikersForm : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";

        SqlConnection conn;

        //this one stores the ID of the hiker we clicked on in the grid
        private int selectedParticipantID;

        public MaintainHikersForm()
        {
            InitializeComponent();
        }

        private void MaintainHikersForm_Load(object sender, EventArgs e)
        {
            txtSearchHiker.PlaceholderText = "Search a participant...";
            //load the hikers into the grid when the form opens
            loadHikers();
            //also style the grid so it looks nice
            styleDataGridViewHikers();
        }

        //this funtion pulls all the participants from the databse and shows them in the grid
        private void loadHikers()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = @"SELECT ParticipantID, FirstName, LastName, IDNumber, PhoneNumber FROM Participant";
                SqlCommand comm = new SqlCommand(sqlQuery, conn);
                DataTable dt = new DataTable();

                adapter.SelectCommand = comm;
                adapter.Fill(dt);
                dataGridViewHikers.DataSource = dt;

                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void styleDataGridViewHikers()
        {
            dataGridViewHikers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHikers.EnableHeadersVisualStyles = false;
            dataGridViewHikers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 191, 99);
            dataGridViewHikers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewHikers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridViewHikers.RowTemplate.Height = 30;
        }

        //this adds the action button colum to the grid, we check first so we dont add it twice
        private void AddActionColumn()
        {
            if (dataGridViewHikers.Columns.Contains("Action"))
            {
                return;
            }

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Action";
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Select Action";
            btnColumn.UseColumnTextForButtonValue = true;

            
            btnColumn.DefaultCellStyle.BackColor = Color.FromArgb(6, 71, 96);
            btnColumn.DefaultCellStyle.ForeColor = Color.White;

            dataGridViewHikers.Columns.Add(btnColumn);
        }

        
        private void btnAddHiker_Click(object sender, EventArgs e)
        {
            AddHikerForm form = new AddHikerForm();
            form.ShowDialog();
            //reload the grid once the dialog closes so we can see the new hiker
            loadHikers();
        }

        //this runs when someone clicks anywhere in the grid, we check if they clicked the action column
        private void dataGridViewHikers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if rowindex is less than 0 it means the header was clicked, just ignore it
            if (e.RowIndex < 0)
            {
                return;
            }

            //we only care if the action column was clicked, otherwise just return
            if (dataGridViewHikers.Columns[e.ColumnIndex].Name != "Action")
            {
                return;
            }

            //get the participantID from the row that was clicked so we know which hiker
            selectedParticipantID = Convert.ToInt32(
                dataGridViewHikers.Rows[e.RowIndex]
                .Cells["ParticipantID"].Value);

            //clear the menu first before we add items otherwise it will just keep adding
            cmsHikerActions.Items.Clear();

            //hikers always have 2 options which is edit and view details
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            editItem.ForeColor = Color.Black;
            editItem.BackColor = Color.White;

            cmsHikerActions.Items.Add(editItem);

            ToolStripMenuItem viewItem = new ToolStripMenuItem("View Details");
            viewItem.ForeColor = Color.White;
            viewItem.BackColor = Color.FromArgb(52, 95, 173);

            cmsHikerActions.Items.Add(viewItem);

            //show the context menu just below the button that was clicked
            if (cmsHikerActions.Items.Count > 0)
            {
                Rectangle cellRect =
                    dataGridViewHikers.GetCellDisplayRectangle(
                        e.ColumnIndex,
                        e.RowIndex,
                        true);

                cmsHikerActions.Show(
                    dataGridViewHikers,
                    cellRect.Left,
                    cellRect.Bottom);
            }
        }

        //this runs when the user picks one of the options from the dropdown menu
        private void cmsHikerActions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cmsHikerActions.Close();

            string action = e.ClickedItem.Text;

            //check which option was selected and call the right funtion
            switch (action)
            {
                case "Edit":
                    EditHiker(selectedParticipantID);
                    break;
                case "View Details":
                    ViewHikerDetails(selectedParticipantID);
                    break;
            }
        }

        //open the edit form and pass the participantID so it knows which hiker to load
        private void EditHiker(int selectedParticipantID)
        {
            EditHikerForm form = new EditHikerForm(selectedParticipantID);

            form.ShowDialog();

            //refresh the grid after editing so changes show
            loadHikers();
        }

        //open the view details form, also read only so the ranger cant change anything here
        private void ViewHikerDetails(int selectedParticipantID)
        {
            ViewHikerDetailsForm form = new ViewHikerDetailsForm(selectedParticipantID);

            form.ShowDialog();

            loadHikers();
        }

        private void pnlFormContent_Paint(object sender, PaintEventArgs e)
        {

        }

        //search for a hiker by name or ID number
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchString = txtSearchHiker.Text.Trim();

                conn = new SqlConnection(connString);
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();

                //use LIKE so the search works even if they only type part of the name
                string sqlQuery = @"SELECT ParticipantID, FirstName, LastName, IDNumber, PhoneNumber FROM Participant WHERE FirstName LIKE '%" + searchString + "%' OR LastName LIKE '%" + searchString + "%' OR IDNumber LIKE '%" + searchString + "%'";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                DataTable dt = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                dataGridViewHikers.DataSource = dt;
                AddActionColumn();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //refresh button clears the search and loads everything again
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadHikers();

            //reset the search box back to empty
            txtSearchHiker.Text = "";
            txtSearchHiker.PlaceholderText = "Search a participant...";
        }
    }
}