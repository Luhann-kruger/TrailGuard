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
    public partial class CreatePermitForm : Form
    {
        int parkID;
        int trailID;
        private DateTime selectedDate;
        private TimeSpan expectedReturnTime = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);

        //List to  store all the selected participant's Id
        private List<int> selectedParticpantIds = new List<int>();


        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TrailGuardDB;Integrated Security=True;";


        SqlConnection conn;
        public CreatePermitForm()
        {
            InitializeComponent();
        }

        private void CreatePermitForm_Load(object sender, EventArgs e)
        {
            LoadParks();

            //Initialize the selected date to today
            selectedDate = DateTime.Today;
            

            loadParticipants();

            styleDGVParticipants();

            //Load default selections for each participant
            SetInitialBtnActionValues();

            txtSearchParticipant.PlaceholderText = "Search a participant by first name, last name or participant ID...";
        }

        //function that add an actions column with action buttons
        private void AddActionColumn()
        {

            if (dgvParticipants.Columns.Contains("Actions"))
            {
                return;
            }

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Actions";
            btnColumn.HeaderText = "Actions";
            //btnColumn.Text = "Select Action";
            btnColumn.UseColumnTextForButtonValue = false;
            btnColumn.FlatStyle = FlatStyle.Flat;

            //default color styling of the action buttons
            //btnColumn.DefaultCellStyle.BackColor = Color.FromArgb(6, 71, 96);
            btnColumn.DefaultCellStyle.ForeColor = Color.White;

            dgvParticipants.Columns.Add(btnColumn);
        }

        //Populate the Actions button column with "Add" or "Remove" whether the value is in the list or not
        private void SetInitialBtnActionValues()
        {
            foreach (DataGridViewRow row in dgvParticipants.Rows)
            {
                if (row.IsNewRow) continue;

                int participantId = Convert.ToInt32(row.Cells["ParticipantID"].Value);
                DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["Actions"];

                if (selectedParticpantIds.Contains(participantId))
                {
                    row.Cells["Actions"].Value = "Remove";
                    row.DefaultCellStyle.BackColor = Color.LightGreen;

                    // Red Remove button
                    btnCell.Style.BackColor = Color.FromArgb(198, 40, 40);
                    btnCell.Style.ForeColor = Color.White;


                }
                else
                {
                    row.Cells["Actions"].Value = "Add";
                    row.DefaultCellStyle.BackColor = Color.White;

                    // Green Add button
                    btnCell.Style.BackColor = Color.FromArgb(46, 125, 50);
                    btnCell.Style.ForeColor = Color.White;
                }
            }
        }

        //Load all the registered participants into the dgvParticipants 
        private void loadParticipants()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = @"SELECT ParticipantID,FirstName, LastName, IDNumber, PhoneNumber FROM Participant";
                SqlCommand comm = new SqlCommand(sqlQuery, conn);
                DataTable dt = new DataTable();

                adapter.SelectCommand = comm;
                adapter.Fill(dt);
                dgvParticipants.DataSource = dt;

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
        private void styleDGVParticipants()
        {
            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipants.EnableHeadersVisualStyles = false;
            dgvParticipants.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 191, 99);
            dgvParticipants.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvParticipants.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvParticipants.RowTemplate.Height = 30;
        }

        //function that loads the parks into cmbSelectPark
        private void LoadParks()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string sqlQuery = "SELECT ParkID, ParkName FROM Park ORDER BY ParkName";

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);

                adapter.Fill(dt);

                cmbSelectPark.DisplayMember = "ParkName";
                cmbSelectPark.ValueMember = "ParkID";
                cmbSelectPark.DataSource = dt;


                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading parks: " + ex.Message);
            }
        }

        private void LoadTrails()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string sqlQuery = "SELECT TrailID, TrailName FROM Trail WHERE ParkID = @parkID";

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                cmd.Parameters.AddWithValue("@parkID", parkID);


                adapter.SelectCommand = cmd;


                adapter.Fill(dt);



                cmbSelectTrail.DisplayMember = "TrailName";
                cmbSelectTrail.ValueMember = "TrailID";
                cmbSelectTrail.DataSource = dt;


                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading Trails: " + ex.Message);
            }
        }

        private void cmbSelectPark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectPark.SelectedValue != null && cmbSelectPark.SelectedValue != DBNull.Value)
            {
                parkID = Convert.ToInt32(cmbSelectPark.SelectedValue);

                // load trails only if a park was selected
                if (parkID >= 0)
                {
                    LoadTrails();
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSelectTrail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectTrail.SelectedValue != null)
            {
                trailID = Convert.ToInt32(cmbSelectTrail.SelectedValue);

            }
        }

        private void dtpPermitDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpPermitDate.Value.Date;
        }

        private void dtpExpectedReturnTime_ValueChanged(object sender, EventArgs e)
        {
            expectedReturnTime = new TimeSpan(dtpExpectedReturnTime.Value.Hour, dtpExpectedReturnTime.Value.Minute, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvParticipants.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            // NOTE PROGRAM STILL CRASH WHEN I CLICK IN THE LAST ACTION COLUMN CELL WITHOUT A BUTTON
            if (e.ColumnIndex == dgvParticipants.Columns["Actions"].Index)
            {
                int participantId = Convert.ToInt32(dgvParticipants.Rows[e.RowIndex].Cells["ParticipantID"].Value);
                DataGridViewButtonCell btnCell = (DataGridViewButtonCell)dgvParticipants.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (!selectedParticpantIds.Contains(participantId))
                {

                    //Add Action
                    selectedParticpantIds.Add(participantId);
                    btnCell.Value = "Remove";

                    //Style the selected row color
                    dgvParticipants.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

                    //style the button
                    btnCell.Style.BackColor = Color.FromArgb(198, 40, 40);  // Red BG
                    btnCell.Style.ForeColor = Color.FromArgb(255, 255, 255); // White Text

                }
                else
                {
                    //Remove Action
                    selectedParticpantIds.Remove(participantId);
                    btnCell.Value = "Add";

                    //Style the selected row color
                    dgvParticipants.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

                    //style the button
                    btnCell.Style.BackColor = Color.FromArgb(46, 125, 50);   // Green BG
                    btnCell.Style.ForeColor = Color.FromArgb(255, 255, 255); // White Text
                }
            }
        }

        private void btnClearParticipants_Click(object sender, EventArgs e)
        {
            //Clear all selected participantId
            selectedParticpantIds.Clear();

            foreach (DataGridViewRow row in dgvParticipants.Rows)
            {
                if (row.IsNewRow) continue;

                //Reset row background
                row.DefaultCellStyle.BackColor = Color.White;

                //Get the action button
                DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["Actions"];

                //Reset the button
                btnCell.Value = "Add";
                btnCell.Style.BackColor = Color.FromArgb(46, 125, 50);
                btnCell.Style.ForeColor = Color.White;

            }
        }

        private void btnSearchParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearchParticipant.Text.Trim();


                conn = new SqlConnection(connString);
                conn.Open();
                string sqlQuery = @"SELECT ParticipantID, FirstName, LastName, IDNumber, PhoneNumber FROM Participant WHERE FirstName LIKE @search OR LastName LIKE @search
                        or CAST(ParticipantID as VARCHAR(20)) LIKE @search ORDER BY FirstName, LastName";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvParticipants.DataSource = dt;

                conn.Close();

                //Reset the action column if necessary
                SetInitialBtnActionValues();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReloadAll_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = @"SELECT ParticipantID,FirstName, LastName, IDNumber, PhoneNumber FROM Participant";
                SqlCommand comm = new SqlCommand(sqlQuery, conn);
                DataTable dt = new DataTable();

                adapter.SelectCommand = comm;
                adapter.Fill(dt);
                dgvParticipants.DataSource = dt;

                //Load Action columns
                AddActionColumn();

                conn.Close();

                //Reload action buttons styling
                SetInitialBtnActionValues();

                txtSearchParticipant.Clear();
                txtSearchParticipant.PlaceholderText = "Search a participant by first name, last name or participant ID...";

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatePermit_Click(object sender, EventArgs e)
        {
            //Check that at least one participant is selected
            if (selectedParticpantIds.Count == 0) {
                MessageBox.Show("Please add at least one participant to this permit.", "Validation Error");
                return;
            }

            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sqlQuery = "INSERT INTO Permit (TrailID,ExpectedReturnTime,Date,Status)" +
                        "VALUES (@TrailID, @ExpectedReturnTime, @Date, @Status);" +
                        "SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conn, transaction);

                    cmd.Parameters.AddWithValue("@TrailID", trailID);
                    cmd.Parameters.AddWithValue("@ExpectedReturnTime", expectedReturnTime);
                    cmd.Parameters.AddWithValue("@Date", selectedDate);
                    cmd.Parameters.AddWithValue("@Status", "Registered");

                    int permitID = Convert.ToInt32(cmd.ExecuteScalar());

                    //Add participants to Permit_Participant
                    foreach (int participantID in selectedParticpantIds)
                    {
                        string participantSQLQuery = @"INSERT INTO Permit_Participant (PermitID, ParticipantID) VALUES (@PermitID, @ParticipantID)";

                        SqlCommand cmdParticipant = new SqlCommand(participantSQLQuery, conn, transaction);

                        cmdParticipant.Parameters.AddWithValue("@PermitID", permitID);
                        cmdParticipant.Parameters.AddWithValue("@ParticipantID", participantID);

                        cmdParticipant.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Permit created successfully.");


                    //conn.Close();
                    this.Close();

                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    
                }
            }
        }
    }
}
