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
    public partial class EditHikerForm : Form
    {
      
        private int selectedParticipantID;

        public EditHikerForm(int participantID)
        {
            InitializeComponent();
            selectedParticipantID = participantID;
        }

        private void EditHikerForm_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}