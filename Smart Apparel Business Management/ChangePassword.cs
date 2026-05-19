using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OGA0PO\SQLEXPRESS;Initial Catalog=Smart_Apparel_Business_Management;Integrated Security=True");
        private void btnchangeSubmit_Click(object sender, EventArgs e)
        {
            if (txtChangeuname.Text == "" || txtCCurrentPassword.Text == "" || txtChangenewpass.Text == "")
            {
                MessageBox.Show("Please fill up all data");
                return;
            }

            string query = "UPDATE Users SET Password = '" + txtChangenewpass.Text +
                           "' WHERE Username = '" + txtChangeuname.Text +
                           "' AND Password = '" + txtCCurrentPassword.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();

            if (row > 0)
            {
                MessageBox.Show("Password changed successfully");
            }
            else
            {
                MessageBox.Show("Username or current password is wrong");
            }
        }

        private void btnChangeback_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            this.Hide();
        }
    }
}
