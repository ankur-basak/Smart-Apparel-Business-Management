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
            lblerrorupass.Text = lblerrormsguname.Text = "";

            username = txtuname.Text;
            password = txtupass.Text;

            if (txtuname.Text == "")
            {
                lblerrormsguname.Text = "Please enter username";
            }
            if (txtupass.Text == "")
            {
                lblerrorupass.Text = "Please Enter Password";

                if (txtuname.Text != "" && txtupass.Text != "")
                {

                }
            }
            if (txtuname.Text == username && txtupass.Text == password)
            {
                SqlConnection con = new SqlConnection(@"Data Source=ankur\sqlexpress;Initial Catalog=ApparelDB;Integrated Security=True;");
                con.Open();
                string query = "SELECT * FROM UsersTB WHERE Username='" + username + "' AND Password='" + password + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Succesfully logged in");
                    DashBoard dashBoard = new DashBoard(txtuname.Text);
                    dashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
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