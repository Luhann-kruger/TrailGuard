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
    public partial class CreateIncidentReportForm : Form
    {


        public CreateIncidentReportForm(int permitID)
        {
            InitializeComponent();
          
        }

        private void CreateIncidentReportForm_Load(object sender, EventArgs e)
        {
           
        }


        private void btnCreateIncidentReport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
