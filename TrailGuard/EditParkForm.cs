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
    public partial class EditParkForm : Form
    {
        //variable that saves the pass
        private int parkID;

        //paramenter in the constructor to pass the parkID to this form when the edit button on the maintainParksForm is clicked in the dataGridView
        public EditParkForm(int parkID)
        {
            InitializeComponent();
            this.parkID = parkID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditParkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
