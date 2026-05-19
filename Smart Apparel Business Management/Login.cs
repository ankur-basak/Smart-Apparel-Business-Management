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
            try
            {
                if (txtuname.Text == "")
                {
                    MessageBox.Show("Enter Email");
                    return;
                }

                if (txtupass.Text == "")
                {
                    MessageBox.Show("Enter Password");
                    return;
                }

                DataAccess da = new DataAccess();

                string query =
                    "SELECT * FROM Users " +
                    "WHERE email = '" + txtuname.Text + "' " +
                    "AND password = '" + txtupass.Text + "' " +
                    "AND status = 'Active'";

                DataTable dt = da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string role = dt.Rows[0]["role"].ToString();

                    int userId = Convert.ToInt32(dt.Rows[0]["userId"]);

                    MessageBox.Show("Login Successful");

                    // ADMIN LOGIN
                    if (role == "Admin")
                    {
                        this.Hide();

                        DashBoard db = new DashBoard(txtuname.Text);

                        db.Show();
                    }

                    // INVENTORY MANAGER LOGIN
                    else if (role == "Inventory Manager")
                    {
                        this.Hide();

                        Inventory_Manager im = new Inventory_Manager(userId);

                        im.idManager = userId;

                        im.Show();
                    }
                    else
                    {
                        MessageBox.Show("Role Not Found");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
          
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