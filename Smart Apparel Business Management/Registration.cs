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
using System.Xml.Linq;

namespace Smart_Apparel_Business_Management
{
    public partial class Registration : Form
    {
        private string name;
        private string username;
        private string password;
        private string email;
        private string gender;
        private string phone;
        private DateTime dateOfBirth;
        private string department;
        private string address;
        public Registration()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            name = txtname.Text;
            username = txtuname.Text;
            password = txtpass.Text;
            department = cbdept.Text;
            email = txtemail.Text;
            phone = txtphone.Text;
            dateOfBirth = Convert.ToDateTime(txtdob.Text);
            address = txtaddress.Text;

            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = " ";
            }

            lblerrorpass.Text = lblerrorname.Text = lblerrordept.Text = lblerroruname.Text = lblerroremail.Text = lblerrorphone.Text = lblerrordob.Text = lblerrorgender.Text = lblerroraddress.Text = "";
            if (txtname.Text == "")
            {
                lblerrorname.Text = "Please enter username";
            }
            if (txtpass.Text == "")
            {
                lblerrorpass.Text = "Please Enter Password";
            }
            if (cbdept.Text == "")
            {
                lblerrordept.Text = "Please enter your department";
            }
            if (txtuname.Text == "")
            {
                lblerroruname.Text = "Please enter username";
            }
            if (txtemail.Text == "")
            {
                lblerroremail.Text = "Please enter email";
            }
            if (txtphone.Text == "")
            {
                lblerrorphone.Text = "Please enter phone number";
            }
            if (txtdob.Text == "")
            {
                lblerrordob.Text = "Please enter date of birth";
            }
            if (rbmale.Checked == false && rbfemale.Checked == false && rbother.Checked == false)
            {
                lblerrorgender.Text = "Please select gender";
            }
            if (txtaddress.Text == "")
            {
                lblerroraddress.Text = "Please enter address";
                if (txtname.Text != "" && txtpass.Text != "" && cbdept.Text != "" && txtuname.Text != "" && txtemail.Text != "" && txtphone.Text != "" && txtaddress.Text != "" && txtdob.Text != "" && gender != " ")
                {

                }
            }

            if (txtname.Text == name && txtpass.Text == password && cbdept.Text == department && txtuname.Text == username && txtemail.Text == email && txtphone.Text == phone && gender != " " && txtaddress.Text == address && Convert.ToDateTime(txtdob.Text) == dateOfBirth)
            {
                SqlConnection con = new SqlConnection(@"Data Source=ankur\sqlexpress;Initial Catalog=ApparelDB;Integrated Security=True;");
                con.Open();
                string query = "INSERT INTO UsersTB(Name, Username, Password,Department, Email, Phone, DateOfBirth, Address, Gender) Values('" + name + "', '" + username + "', '" + password + "', '" + department + "', '" + email + "', '" + phone + "', '" + dateOfBirth + "', '" + address + "','" + gender + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Registered");

                Login log = new Login();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Information");
            }

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
