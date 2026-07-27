namespace TrailGuard
{
    public partial class ParentMDIAdminForm : Form
    {
        public ParentMDIAdminForm()
        {
            InitializeComponent();
            // declare form as MDI parent form
            this.IsMdiContainer = true;
        }

        private void ParentMDIAdminForm_Load(object sender, EventArgs e) {
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlSidebarMenu.Width = 200;
            pnlSidebarMenu.Dock = DockStyle.Left;

            //Also load the maintainTrails child form when the ParentMDIAdminForm loads
            loadMaintainTrailsForm();

            
        }

        //Function that helps with the opening and closing of MDI child forms.
        private void OpenChild(Form childForm) {
            foreach (Form form in this.MdiChildren) {
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

        //Function that loads the maintainTrails child form into this ParentMDIAdminForm.
        private void loadMaintainTrailsForm()
        {
            OpenChild(new mantainTrailsForm());
            
        }

        // Function that loads maintainParks child form into the ParentMDIAdmin Form
        private void loadMaintainParksForm() {
            OpenChild(new maintainParksForm());
        }

        // Implement the sidebar buttons to load these child forms
        private void btnMaintainParks_Click(object sender, EventArgs e) {
            loadMaintainParksForm();
        }

        private void btnMaintainTrails_Click(object sender, EventArgs e) {
            loadMaintainTrailsForm();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e) { 
            GenerateReportsForm form = new GenerateReportsForm();
            form.ShowDialog();
            //Add load data function later to reload the data once the form dialog closes.
        }

    }
}
