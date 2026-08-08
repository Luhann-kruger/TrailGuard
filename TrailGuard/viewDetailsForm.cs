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
    public partial class viewDetailsForm : Form
    {
        int selectedPermitID;
        public viewDetailsForm(int selectedPermitID)
        {
            InitializeComponent();
            this.selectedPermitID = selectedPermitID;
        }

        private void viewDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
