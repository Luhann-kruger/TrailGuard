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
    public partial class editPermitForm : Form
    {
        //Stores the id of the permit that is being editted
        int editPermitID;
        public editPermitForm(int editPermitID)
        {
            InitializeComponent();
            this.editPermitID = editPermitID;
        }

        private void editPermitForm_Load(object sender, EventArgs e)
        {

        }

        private void lblModeTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
