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
    public partial class adminOperation : Form
    {
        public adminOperation()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=ANKUR\SQLEXPRESS;Initial Catalog=ApparelDB;Integrated Security=True");

        private void LoadEmployees()
        {
            string query = "SELECT * FROM Registration";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbother_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rbmale.Checked)
                gender = "Male";
            else if (rbfemale.Checked)
                gender = "Female";
            else if (rbother.Checked)
                gender = "Other";

            string query = "INSERT INTO UsersTB " +
                           "(Name, Username, Password, Department, Email, Phone, DateOfBirth, Address, Gender) " +
                           "VALUES " +
                           "('" + txtname.Text + "', " +
                           "'" + txtuname.Text + "', " +
                           "'" + txtpass.Text + "', " +
                           "'" + cbdept.Text + "', " +
                           "'" + txtemail.Text + "', " +
                           "'" + txtphone.Text + "', " +
                           "'" + Convert.ToDateTime(txtdob.Text)+ "', " +
                           "'" + txtaddress.Text + "', " +
                           "'" + gender + "')";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            int row = cmd.ExecuteNonQuery();

            con.Close();

            if (row > 0)
            {
                MessageBox.Show("Employee added successfully");
            }
            else
            {
                MessageBox.Show("Failed to add employee");
            }
        }

        private void btnUpE_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rbmale.Checked)
                gender = "Male";
            else if (rbfemale.Checked)
                gender = "Female";
            else if (rbother.Checked)
                gender = "Other";

            string query = "UPDATE UsersTB SET " +
                           "Name = '" + txtname.Text + "', " +
                           "Username = '" + txtuname.Text + "', " +
                           "Password = '" + txtpass.Text + "', " +
                           "Department = '" + cbdept.Text + "', " +
                           "Email = '" + txtemail.Text + "', " +
                           "Phone = '" + txtphone.Text + "', " +
                           "DateOfBirth = '" + Convert.ToDateTime(txtdob.Text) + "', " +
                           "Address = '" + txtaddress.Text + "', " +
                           "Gender = '" + gender + "' " +
                           "WHERE Username = '" + txtuname.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();

            if (row > 0)
            {
                MessageBox.Show("Employee updated successfully");
            }
            else
            {
                MessageBox.Show("No employee found with this User ID");
            }

        }

        private void btnTerminateEmp_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM UsersTB WHERE Username = '" + txtuname.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();

            if (row > 0)
            {
                MessageBox.Show("Employee terminated successfully");
                dataGridView1.DataSource = null;
            }
            else
            {
                MessageBox.Show("No employee found with this User ID");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM UsersTB WHERE Username = '" + txtuname.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No employee found");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtuname.Clear();
            txtpass.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtaddress.Clear();

            cbdept.SelectedIndex = -1;

            rbmale.Checked = false;
            rbfemale.Checked = false;
            rbother.Checked = false;

            dataGridView1.DataSource = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard("");
            db.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadEmployees();
        }
    }
}
