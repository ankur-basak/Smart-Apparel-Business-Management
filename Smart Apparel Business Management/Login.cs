using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smart_Apparel_Business_Management
{
    public partial class Login : Form
    {
        private string uname = "Ankur Basak";
        private string pass = "12345";
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
            if (txtuname.Text == uname && txtupass.Text == pass)
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ANKUR\\SQLEXPRESS;Initial Catalog=LOGIN_DB;Integrated Security=True";
            /*con.Open();
            string query = "Insert into login_table(Username, password) values('Ankur', '12345')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();*/
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