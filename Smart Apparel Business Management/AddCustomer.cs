using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            btnaddC.Click += btnaddC_Click;
            btnBack3.Click += btnBack3_Click;
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void btnaddC_Click(object sender, EventArgs e)
        {
            string name = txtCbox1.Text.Trim();
            string phone = txtCbox2.Text.Trim();
            string email = txtCbox3.Text.Trim();

            if (name == "") { MessageBox.Show("Please enter customer name."); txtCbox1.Focus(); return; }
            if (phone == "") { MessageBox.Show("Please enter customer phone."); txtCbox2.Focus(); return; }
            if (email == "") { MessageBox.Show("Please enter customer email."); txtCbox3.Focus(); return; }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtCbox3.Focus();
                return;
            }

            try
            {
                SalesDataStore.AddCustomer(name, phone, email);
                MessageBox.Show("Customer added successfully.");
                txtCbox1.Clear(); txtCbox2.Clear(); txtCbox3.Clear(); txtCbox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer save error:\n" + ex.Message);
            }
        }

        private void btnBack3_Click(object sender, EventArgs e) { this.Close(); }
    }
}
