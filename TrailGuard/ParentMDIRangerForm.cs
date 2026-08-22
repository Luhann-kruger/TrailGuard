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
    public partial class ParentMDIRangerForm : Form
    {

        private ChatForm chatForm = null;
        

        User loggedInUser;
        public ParentMDIRangerForm(User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void ParentMDIRangerForm_Load(object sender, EventArgs e)
        {
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlSidebarMenu.Width = 200;
            pnlSidebarMenu.Dock = DockStyle.Left;

            //Also load the maintainPermits child form when the ParentMDIRangerForm loads
            loadMaintainPermitsForm();
        }

        //Function that helps with the opening and closing of MDI child forms.
        private void OpenChild(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                //Close all the current MDI children beform loading a new child form
                form.Close();
            }

            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ControlBox = false;
            childForm.Text = "";
            childForm.Dock = DockStyle.Fill;
            childForm.Show();

        }

        private void loadMaintainPermitsForm()
        {
            OpenChild(new maintainPermitsForm());
        }

        private void loadMaintainHikersForm()
        {
            //Merge hikers form into this and implement
            OpenChild(new MaintainHikersForm());
        }

        private void btnMaintainPermits_Click(object sender, EventArgs e)
        {
            loadMaintainPermitsForm();
        }

        private void btnMaintainHikers_Click(object sender, EventArgs e)
        {
            loadMaintainHikersForm();
        }

        private void btnAskTrailGuardAI_Click(object sender, EventArgs e)
        {
            // if an existing chat is not open then open one
            if (chatForm == null || chatForm.IsDisposed)
            {
                // the chat form does use the open child method as it is conflicting with the look 
                chatForm = new ChatForm();
                chatForm.MdiParent = this;
                chatForm.Show();
            }
            else
            {
                // if the vhat is already open then open it again
                chatForm.Activate();

            }

        }
        private void pnlSidebarMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedInUser = null;

            LoginForm loginForm = new LoginForm();

            this.Hide();

            loginForm.ShowDialog();

            this.Close();
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            ModesForm form = new ModesForm(loggedInUser);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
