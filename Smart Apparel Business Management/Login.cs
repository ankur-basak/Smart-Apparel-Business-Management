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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Smart_Apparel_Business_Management
{
    public partial class Login : Form
    {
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btulogin_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "")
            {
                lblerrormsguname.Text = "Please enter username";
                return;
            }

            if (txtupass.Text == "")
            {
                lblerrorupass.Text = "Please Enter Password";
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=ANKUR\SQLEXPRESS;Initial Catalog=ApparelDB;Integrated Security=True");
            con.Open();

            string query = "SELECT * FROM UsersTB WHERE Username='" + txtuname.Text + "' AND Password='" + txtupass.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Successfully logged in");
                DashBoard dashboard = new DashBoard(txtuname.Text);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

            con.Close();

        }
        private void btusignup_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnforgetpass_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
            this.Hide();
        }
    }
}