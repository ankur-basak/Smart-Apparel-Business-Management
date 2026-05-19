using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void btnIR_Click(object sender, EventArgs e)
        {

        }

        private void btnSR_Click(object sender, EventArgs e)
        {

        }

        private void btnHR_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard("");
            db.Show();
            this.Hide();
        }
    }
}
