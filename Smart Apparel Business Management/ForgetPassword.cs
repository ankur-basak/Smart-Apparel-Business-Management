using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class ForgetPassword : Form
    {
        private string Username;
        private string Email;
        private string NewPassword;
        private string ConfirmPassword;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnforgetsubmit_Click(object sender, EventArgs e)
        {
            Username = txtforgetuname.Text;
            Email = txtforgetemail.Text;
            NewPassword = txtforgetnewpass.Text;
            ConfirmPassword = txtforgetconfirmpass.Text;

            lblferroruname.Text = lblferroremail.Text = lblferrorNpass.Text = lblferrorCpass.Text = "";

            if (txtforgetuname.Text == "")
            {
                lblferroruname.Text = "Please enter your username";
            }
            if (txtforgetemail.Text == "")
            {
                lblferroremail.Text = "Please enter your email";
            }
            if (txtforgetnewpass.Text == "")
            {
                lblferrorNpass.Text = "Please enter a new password";
            }
            if (txtforgetconfirmpass.Text == "")
            {
                lblferrorCpass.Text = "Please confirm your password";
            }

            if(txtforgetuname.Text!="" && txtforgetemail.Text!="" && txtforgetnewpass.Text!="" && txtforgetconfirmpass.Text!="")
            {
               if (txtforgetnewpass.Text == txtforgetconfirmpass.Text)
               {
                  MessageBox.Show("Password reset successfully");
                  MessageBox.Show("User: " + Username + "\nEmail: " + Email + "\nNew Password: " + NewPassword + "\nConfirmed Password: " + ConfirmPassword);
               }
                else
                {
                  MessageBox.Show("Password reset failed.Passwords do not match.");
                }
            }
            else
            {
              MessageBox.Show("Password reset failed. Please check your information and try again.");
            }
            
        }
        
        private void Btnforgetback_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void lblcurrentpass_Click(object sender, EventArgs e)
        {

        }
        private void txtforgetcurrentpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
