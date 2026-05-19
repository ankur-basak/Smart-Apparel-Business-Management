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
    public partial class HR_Operation : Form
    {
        public HR_Operation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           HR_Department hr = new HR_Department();
            hr.Show();
            this.Hide();
        }
    }
}
