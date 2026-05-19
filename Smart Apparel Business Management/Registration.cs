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

       
        //private void btnsubmit_Click(object sender, EventArgs e)
        //{
        //    name = txtname.Text.Trim();
        //    username = txtuname.Text.Trim();
        //    password = txtpass.Text.Trim();
        //    department = cbdept.Text.Trim();
        //    email = txtemail.Text.Trim();
        //    phone = txtphone.Text.Trim();
        //    dateOfBirth = txtdob.Value;
        //    address = txtaddress.Text.Trim();

        //    // Gender
        //    if (rbmale.Checked)
        //    {
        //        gender = "Male";
        //    }
        //    else if (rbfemale.Checked)
        //    {
        //        gender = "Female";
        //    }
        //    else if (rbother.Checked)
        //    {
        //        gender = "Other";
        //    }
        //    else
        //    {
        //        gender = "";
        //    }

        //    // Clear Error Labels
        //    lblerrorname.Text = "";
        //    lblerroruname.Text = "";
        //    lblerrorpass.Text = "";
        //    lblerrordept.Text = "";
        //    lblerroremail.Text = "";
        //    lblerrorphone.Text = "";
        //    lblerrordob.Text = "";
        //    lblerrorgender.Text = "";
        //    lblerroraddress.Text = "";

        //    bool isValid = true;

        //    // Validation
        //    if (name == "")
        //    {
        //        lblerrorname.Text = "Please enter name";
        //        isValid = false;
        //    }

        //    if (username == "")
        //    {
        //        lblerroruname.Text = "Please enter username";
        //        isValid = false;
        //    }

        //    if (password == "")
        //    {
        //        lblerrorpass.Text = "Please enter password";
        //        isValid = false;
        //    }

        //    if (department == "")
        //    {
        //        lblerrordept.Text = "Please select department";
        //        isValid = false;
        //    }

        //    if (email == "")
        //    {
        //        lblerroremail.Text = "Please enter email";
        //        isValid = false;
        //    }

        //    if (phone == "")
        //    {
        //        lblerrorphone.Text = "Please enter phone";
        //        isValid = false;
        //    }

        //    if (address == "")
        //    {
        //        lblerroraddress.Text = "Please enter address";
        //        isValid = false;
        //    }

        //    if (gender == "")
        //    {
        //        lblerrorgender.Text = "Please select gender";
        //        isValid = false;
        //    }

        //    // Stop if invalid
        //    if (!isValid)
        //    {
        //        MessageBox.Show("Please fill all fields correctly");
        //        return;
        //    }

        //    try
        //    {
        //        SqlConnection con = new SqlConnection(
        //            @"Data Source=DESKTOP-2OGA0PO\SQLEXPRESS;
        //    Initial Catalog=SmartApparelManagementSystem;
        //    Integrated Security=True;
        //    TrustServerCertificate=True");

        //        con.Open();

        //        // Insert into Users table
        //        string query =
        //        "INSERT INTO Users(name, email, phone, address, gender, role, password, status) " +
        //        "VALUES('" + name + "', '" + email + "', '" + phone + "', '" + address + "', '" + gender + "', '" + department + "', '" + password + "', 'Active')";

        //        SqlCommand cmd = new SqlCommand(query, con);

        //        cmd.ExecuteNonQuery();

        //        con.Close();

        //        MessageBox.Show("Successfully Registered");

        //        Login log = new Login();
        //        log.Show();

        //        this.Hide();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

      
        
            private void btnsubmit_Click(object sender, EventArgs e)
        {
            name = txtname.Text.Trim();
            username = txtuname.Text.Trim();
            password = txtpass.Text.Trim();
            department = cbdept.Text.Trim();
            email = txtemail.Text.Trim();
            phone = txtphone.Text.Trim();
            dateOfBirth = txtdob.Value;
            address = txtaddress.Text.Trim();

            // Gender
            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }
            else if (rbother.Checked)
            {
                gender = "Other";
            }
            else
            {
                gender = "";
            }

            // Clear Error Labels
            lblerrorname.Text = "";
            lblerroruname.Text = "";
            lblerrorpass.Text = "";
            lblerrordept.Text = "";
            lblerroremail.Text = "";
            lblerrorphone.Text = "";
            lblerrordob.Text = "";
            lblerrorgender.Text = "";
            lblerroraddress.Text = "";

            bool isValid = true;

            // Validation
            if (name == "")
            {
                lblerrorname.Text = "Please enter name";
                isValid = false;
            }

            if (username == "")
            {
                lblerroruname.Text = "Please enter username";
                isValid = false;
            }

            if (password == "")
            {
                lblerrorpass.Text = "Please enter password";
                isValid = false;
            }

            if (department == "")
            {
                lblerrordept.Text = "Please select department";
                isValid = false;
            }

            if (email == "")
            {
                lblerroremail.Text = "Please enter email";
                isValid = false;
            }

            if (phone == "")
            {
                lblerrorphone.Text = "Please enter phone";
                isValid = false;
            }

            if (address == "")
            {
                lblerroraddress.Text = "Please enter address";
                isValid = false;
            }

            if (gender == "")
            {
                lblerrorgender.Text = "Please select gender";
                isValid = false;
            }

            // Stop if invalid
            if (!isValid)
            {
                MessageBox.Show("Please fill all fields correctly");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(
                    @"Data Source=DESKTOP-2OGA0PO\SQLEXPRESS;
            Initial Catalog=SmartApparelManagementSystem;
            Integrated Security=True;
            TrustServerCertificate=True");

                con.Open();

                // Insert into Users table
                string query =
                "INSERT INTO Users(name, email, phone, address, gender, role, password, status) " +
                "VALUES('" + name + "', '" + email + "', '" + phone + "', '" + address + "', '" + gender + "', '" + department + "', '" + password + "', 'Active')";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Registered");

                Login log = new Login();
                log.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
         
            name = txtname.Text.Trim();
            username = txtuname.Text.Trim();
            password = txtpass.Text.Trim();
            department = cbdept.Text.Trim();
            email = txtemail.Text.Trim();
            phone = txtphone.Text.Trim();
            dateOfBirth = txtdob.Value;
            address = txtaddress.Text.Trim();

            // Gender
            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }
            else if (rbother.Checked)
            {
                gender = "Other";
            }
            else
            {
                gender = "";
            }

            // Clear Error Labels
            lblerrorname.Text = "";
            lblerroruname.Text = "";
            lblerrorpass.Text = "";
            lblerrordept.Text = "";
            lblerroremail.Text = "";
            lblerrorphone.Text = "";
            lblerrordob.Text = "";
            lblerrorgender.Text = "";
            lblerroraddress.Text = "";

            bool isValid = true;

            // Validation
            if (name == "")
            {
                lblerrorname.Text = "Please enter name";
                isValid = false;
            }

            if (username == "")
            {
                lblerroruname.Text = "Please enter username";
                isValid = false;
            }

            if (password == "")
            {
                lblerrorpass.Text = "Please enter password";
                isValid = false;
            }

            if (department == "")
            {
                lblerrordept.Text = "Please select department";
                isValid = false;
            }

            if (email == "")
            {
                lblerroremail.Text = "Please enter email";
                isValid = false;
            }

            if (phone == "")
            {
                lblerrorphone.Text = "Please enter phone";
                isValid = false;
            }

            if (address == "")
            {
                lblerroraddress.Text = "Please enter address";
                isValid = false;
            }

            if (gender == "")
            {
                lblerrorgender.Text = "Please select gender";
                isValid = false;
            }

            // Stop if invalid
            if (!isValid)
            {
                MessageBox.Show("Please fill all fields correctly");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(
                    @"Data Source=DESKTOP-2OGA0PO\SQLEXPRESS;
            Initial Catalog=SmartApparelManagementSystem;
            Integrated Security=True;
            TrustServerCertificate=True");

                con.Open();

                // Insert into Users table
                string query =
                "INSERT INTO Users(name, email, phone, address, gender, role, password, status) " +
                "VALUES('" + name + "', '" + email + "', '" + phone + "', '" + address + "', '" + gender + "', '" + department + "', '" + password + "', 'Active')";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Registered");

                Login log = new Login();
                log.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
    }

