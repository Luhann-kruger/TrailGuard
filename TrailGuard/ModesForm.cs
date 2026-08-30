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
    public partial class ModesForm : Form
    {
        User loggedInUser;
        public ModesForm(User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void ModesForm_Load(object sender, EventArgs e)
        {
            btnRangerMode.Enabled = loggedInUser.Modes.Contains("Ranger");
            btnAdminMode.Enabled = loggedInUser.Modes.Contains("Admin");
            btnRescueMode.Enabled = loggedInUser.Modes.Contains("Rescuer");
            lblRoleTitle.Text = loggedInUser.Username + ", you can access these Modes:";


            // color for btnRangerMode
            if (btnRangerMode.Enabled)
            {
                btnRangerMode.BaseColor = Color.FromArgb(44, 123, 102);
            }
            else
            {
                btnRangerMode.BackColor = Color.Gray;
            }

            //color for btnAdminMode
            if (btnAdminMode.Enabled)
            {
                btnAdminMode.BaseColor = Color.FromArgb(44, 123, 102);
            }
            else
            {
                btnAdminMode.BaseColor = Color.Gray;
            }

            //color for btnRescueMode
            if (btnRescueMode.Enabled)
            {
                btnRescueMode.BaseColor = Color.FromArgb(44, 123, 102);
            }
            else
            {
                btnRescueMode.BaseColor = Color.Gray;
            }


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedInUser = null;

            LoginForm loginForm = new LoginForm();

            this.Hide();

            loginForm.ShowDialog();

            this.Close();
        }

        private void btnRangerMode_Click(object sender, EventArgs e)
        {
            ParentMDIRangerForm form = new ParentMDIRangerForm(loggedInUser);
            this.Hide();

            form.ShowDialog();

            this.Close();
        }

        private void btnAdminMode_Click(object sender, EventArgs e)
        {
            ParentMDIAdminForm form = new ParentMDIAdminForm(loggedInUser);
            this.Hide();

            form.ShowDialog(this);

            this.Close();
        }

        private void btnRescueMode_Click(object sender, EventArgs e)
        {
            ParentMDIRescueForm form = new ParentMDIRescueForm(loggedInUser);
            this.Hide();

            form.ShowDialog();
            this.Close();
        }
    }
}
