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
    public partial class EditTrailForm : Form
    {
        //Stores the ID of the trail to be editted.
        private int editTrailID;

        //passed the trailID as when the EditTrailForm is opened. Can use this ID to load all the data associated to the trail, make edit and save it to the database. 
        public EditTrailForm(int editTrailID)
        {
            InitializeComponent();
            this.editTrailID = editTrailID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditTrailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
