using Diagnostic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothingstore
{
    public partial class EditProfile : Form
    {
        public Inventory_Manager im;
        public int idManager;
        public EditProfile(Inventory_Manager im ,int id)
        {   this.im= im;
            this.idManager = id;
            InitializeComponent();
            LoadProfile();
        }


        private void LoadProfile()
        {
            try
            {
                DataAccess da = new DataAccess();

                string query =
                    "SELECT * FROM Users WHERE userId = " + this.idManager;

                DataTable dt = da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    maskedTextBox1.Text = dt.Rows[0]["name"].ToString();

                    maskedTextBox2.Text = dt.Rows[0]["email"].ToString();

                    maskedTextBox4.Text = dt.Rows[0]["phone"].ToString();

                    maskedTextBox3.Text = dt.Rows[0]["address"].ToString();

                    maskedTextBox7.Text = dt.Rows[0]["password"].ToString();

                    string gender = dt.Rows[0]["gender"].ToString();

                    if (gender == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
           
            try
            {
                DataAccess da = new DataAccess();

                string name = maskedTextBox1.Text;

                string email = maskedTextBox2.Text;

                string phone = maskedTextBox4.Text;

                string address = maskedTextBox3.Text;

                string password = maskedTextBox7.Text;

                string gender = "";

                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    gender = "Female";
                }

                string query =
                    "UPDATE Users SET " +
                    "name = '" + name + "', " +
                    "email = '" + email + "', " +
                    "phone = '" + phone + "', " +
                    "address = '" + address + "', " +
                    "gender = '" + gender + "', " +
                    "password = '" + password + "' " +
                    "WHERE userId = " + this.idManager;

                int count = da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Profile Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            this.im.Visible = true;
        }
    }
}
