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
    public partial class DashBoard : Form
    {
        public DashBoard(string uname)
        {
            InitializeComponent();
            lblwelcomemsg.Text = "Welcome, " +uname;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void lblwelcomemsg_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void btnAdminOperation_Click(object sender, EventArgs e)
        {
            adminOperation adminOperation = new adminOperation();
            adminOperation.Show();
            this.Hide();
        }
    }
}
