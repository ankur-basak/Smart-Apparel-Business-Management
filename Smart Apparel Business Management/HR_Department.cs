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
    public partial class HR_Department : Form
    {
        public HR_Department()
        {
            InitializeComponent();
        }


        private void btnlogOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btnWM_Click(object sender, EventArgs e)
        {
            HR_WorkforceManagement hrwm = new HR_WorkforceManagement();
            hrwm.Show();
            this.Hide();
        }
    }
}
