using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrailGuard
{
    public partial class ParentMDIRescueForm : Form
    {

        private ChatForm chatForm = null;
        

        User loggedInUser;
        public ParentMDIRescueForm(User loggedInUser)

        {
            InitializeComponent();
            // declare form as MDI parent form
            this.IsMdiContainer = true;
            this.loggedInUser = loggedInUser;
        }

        private void ParentMDIRescueForm_Load(object sender, EventArgs e)
        {
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlSidebarMenu.Width = 200;
            pnlSidebarMenu.Dock = DockStyle.Left;
            //Also load the OverduePermits child form when the ParentMDIRescueForm loads
            loadOverduePermitsForm();
        }

        //Function that helps with the opening and closing of MDI child forms.
        private void OpenChild(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                //Close all the current MDI children before loading a new child form
                form.Close();
            }
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ControlBox = false;
            childForm.Text = "";
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        //Function that loads the OverduePermits child form into this ParentMDIRescueForm.
        private void loadOverduePermitsForm()
        {
            OpenChild(new OverduePermitsForm());
        }

        //Function that loads the MaintainRescues child form into this ParentMDIRescueForm.
        private void loadMaintainRescuesForm()
        {
            OpenChild(new MaintainRescuesForm());
        }

        // Implement the sidebar buttons to load these child forms
        private void btnOverduePermits_Click(object sender, EventArgs e)
        {
            loadOverduePermitsForm();
        }

        private void btnMaintainRescues_Click(object sender, EventArgs e)
        {
            loadMaintainRescuesForm();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            loggedInUser = null;

            LoginForm loginForm = new LoginForm();

            this.Hide();

            loginForm.ShowDialog();

            this.Close();
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

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            ModesForm form = new ModesForm(loggedInUser);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }
    }
}
