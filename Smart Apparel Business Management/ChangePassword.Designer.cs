namespace Smart_Apparel_Business_Management
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChangenewpass = new System.Windows.Forms.TextBox();
            this.txtChangeuname = new System.Windows.Forms.TextBox();
            this.lblChangenewpass = new System.Windows.Forms.Label();
            this.lblChangeuname = new System.Windows.Forms.Label();
            this.lblChangeCurrentPass = new System.Windows.Forms.Label();
            this.txtCCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnchangeSubmit = new System.Windows.Forms.Button();
            this.btnChangeback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChangenewpass
            // 
            this.txtChangenewpass.Location = new System.Drawing.Point(166, 105);
            this.txtChangenewpass.Name = "txtChangenewpass";
            this.txtChangenewpass.Size = new System.Drawing.Size(130, 22);
            this.txtChangenewpass.TabIndex = 13;
            // 
            // txtChangeuname
            // 
            this.txtChangeuname.Location = new System.Drawing.Point(167, 42);
            this.txtChangeuname.Name = "txtChangeuname";
            this.txtChangeuname.Size = new System.Drawing.Size(100, 22);
            this.txtChangeuname.TabIndex = 12;
            // 
            // lblChangenewpass
            // 
            this.lblChangenewpass.Location = new System.Drawing.Point(51, 105);
            this.lblChangenewpass.Name = "lblChangenewpass";
            this.lblChangenewpass.Size = new System.Drawing.Size(110, 22);
            this.lblChangenewpass.TabIndex = 11;
            this.lblChangenewpass.Text = "New Password:";
            this.lblChangenewpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeuname
            // 
            this.lblChangeuname.Location = new System.Drawing.Point(74, 42);
            this.lblChangeuname.Name = "lblChangeuname";
            this.lblChangeuname.Size = new System.Drawing.Size(88, 22);
            this.lblChangeuname.TabIndex = 10;
            this.lblChangeuname.Text = "Username: ";
            this.lblChangeuname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeCurrentPass
            // 
            this.lblChangeCurrentPass.Location = new System.Drawing.Point(13, 74);
            this.lblChangeCurrentPass.Name = "lblChangeCurrentPass";
            this.lblChangeCurrentPass.Size = new System.Drawing.Size(149, 22);
            this.lblChangeCurrentPass.TabIndex = 11;
            this.lblChangeCurrentPass.Text = "Current Password:";
            this.lblChangeCurrentPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCCurrentPassword
            // 
            this.txtCCurrentPassword.Location = new System.Drawing.Point(166, 75);
            this.txtCCurrentPassword.Name = "txtCCurrentPassword";
            this.txtCCurrentPassword.Size = new System.Drawing.Size(130, 22);
            this.txtCCurrentPassword.TabIndex = 13;
            // 
            // btnchangeSubmit
            // 
            this.btnchangeSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnchangeSubmit.Location = new System.Drawing.Point(124, 171);
            this.btnchangeSubmit.Name = "btnchangeSubmit";
            this.btnchangeSubmit.Size = new System.Drawing.Size(90, 35);
            this.btnchangeSubmit.TabIndex = 14;
            this.btnchangeSubmit.Text = "Submit";
            this.btnchangeSubmit.UseVisualStyleBackColor = false;
            this.btnchangeSubmit.Click += new System.EventHandler(this.btnchangeSubmit_Click);
            // 
            // btnChangeback
            // 
            this.btnChangeback.BackColor = System.Drawing.Color.Crimson;
            this.btnChangeback.Location = new System.Drawing.Point(220, 173);
            this.btnChangeback.Name = "btnChangeback";
            this.btnChangeback.Size = new System.Drawing.Size(90, 30);
            this.btnChangeback.TabIndex = 15;
            this.btnChangeback.Text = "Back";
            this.btnChangeback.UseVisualStyleBackColor = false;
            this.btnChangeback.Click += new System.EventHandler(this.btnChangeback_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(814, 489);
            this.Controls.Add(this.btnChangeback);
            this.Controls.Add(this.btnchangeSubmit);
            this.Controls.Add(this.txtCCurrentPassword);
            this.Controls.Add(this.txtChangenewpass);
            this.Controls.Add(this.lblChangeCurrentPass);
            this.Controls.Add(this.txtChangeuname);
            this.Controls.Add(this.lblChangenewpass);
            this.Controls.Add(this.lblChangeuname);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChangenewpass;
        private System.Windows.Forms.TextBox txtChangeuname;
        private System.Windows.Forms.Label lblChangenewpass;
        private System.Windows.Forms.Label lblChangeuname;
        private System.Windows.Forms.Label lblChangeCurrentPass;
        private System.Windows.Forms.TextBox txtCCurrentPassword;
        private System.Windows.Forms.Button btnchangeSubmit;
        private System.Windows.Forms.Button btnChangeback;
    }
}