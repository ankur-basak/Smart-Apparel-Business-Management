namespace Smart_Apparel_Business_Management
{
    partial class ForgetPassword
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
            this.lblfrogetuname = new System.Windows.Forms.Label();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.lblforgetemail = new System.Windows.Forms.Label();
            this.btnforgetsubmit = new System.Windows.Forms.Button();
            this.btnforgetback = new System.Windows.Forms.Button();
            this.txtforgetuname = new System.Windows.Forms.TextBox();
            this.txtforgetemail = new System.Windows.Forms.TextBox();
            this.txtforgetnewpass = new System.Windows.Forms.TextBox();
            this.txtforgetconfirmpass = new System.Windows.Forms.TextBox();
            this.lblconfirmpass = new System.Windows.Forms.Label();
            this.lblferroruname = new System.Windows.Forms.Label();
            this.lblferroremail = new System.Windows.Forms.Label();
            this.lblferrorNpass = new System.Windows.Forms.Label();
            this.lblferrorCpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfrogetuname
            // 
            this.lblfrogetuname.Location = new System.Drawing.Point(88, 83);
            this.lblfrogetuname.Name = "lblfrogetuname";
            this.lblfrogetuname.Size = new System.Drawing.Size(88, 22);
            this.lblfrogetuname.TabIndex = 0;
            this.lblfrogetuname.Text = "Username: ";
            this.lblfrogetuname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblnewpass
            // 
            this.lblnewpass.Location = new System.Drawing.Point(65, 156);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(110, 22);
            this.lblnewpass.TabIndex = 2;
            this.lblnewpass.Text = "New Password:";
            this.lblnewpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblforgetemail
            // 
            this.lblforgetemail.Location = new System.Drawing.Point(123, 119);
            this.lblforgetemail.Name = "lblforgetemail";
            this.lblforgetemail.Size = new System.Drawing.Size(52, 22);
            this.lblforgetemail.TabIndex = 3;
            this.lblforgetemail.Text = "E-mail :";
            this.lblforgetemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnforgetsubmit
            // 
            this.btnforgetsubmit.BackColor = System.Drawing.Color.Chartreuse;
            this.btnforgetsubmit.Location = new System.Drawing.Point(135, 267);
            this.btnforgetsubmit.Name = "btnforgetsubmit";
            this.btnforgetsubmit.Size = new System.Drawing.Size(110, 30);
            this.btnforgetsubmit.TabIndex = 4;
            this.btnforgetsubmit.Text = "Submit";
            this.btnforgetsubmit.UseVisualStyleBackColor = false;
            this.btnforgetsubmit.Click += new System.EventHandler(this.btnforgetsubmit_Click);
            // 
            // btnforgetback
            // 
            this.btnforgetback.BackColor = System.Drawing.Color.Crimson;
            this.btnforgetback.Location = new System.Drawing.Point(251, 267);
            this.btnforgetback.Name = "btnforgetback";
            this.btnforgetback.Size = new System.Drawing.Size(90, 30);
            this.btnforgetback.TabIndex = 5;
            this.btnforgetback.Text = "Back";
            this.btnforgetback.UseVisualStyleBackColor = false;
            this.btnforgetback.Click += new System.EventHandler(this.Btnforgetback_Click);
            // 
            // txtforgetuname
            // 
            this.txtforgetuname.Location = new System.Drawing.Point(181, 83);
            this.txtforgetuname.Name = "txtforgetuname";
            this.txtforgetuname.Size = new System.Drawing.Size(100, 26);
            this.txtforgetuname.TabIndex = 6;
            // 
            // txtforgetemail
            // 
            this.txtforgetemail.Location = new System.Drawing.Point(181, 118);
            this.txtforgetemail.Name = "txtforgetemail";
            this.txtforgetemail.Size = new System.Drawing.Size(140, 26);
            this.txtforgetemail.TabIndex = 7;
            // 
            // txtforgetnewpass
            // 
            this.txtforgetnewpass.Location = new System.Drawing.Point(181, 156);
            this.txtforgetnewpass.Name = "txtforgetnewpass";
            this.txtforgetnewpass.Size = new System.Drawing.Size(130, 26);
            this.txtforgetnewpass.TabIndex = 9;
            // 
            // txtforgetconfirmpass
            // 
            this.txtforgetconfirmpass.Location = new System.Drawing.Point(181, 193);
            this.txtforgetconfirmpass.Name = "txtforgetconfirmpass";
            this.txtforgetconfirmpass.PasswordChar = '*';
            this.txtforgetconfirmpass.Size = new System.Drawing.Size(130, 26);
            this.txtforgetconfirmpass.TabIndex = 8;
            this.txtforgetconfirmpass.TextChanged += new System.EventHandler(this.txtforgetcurrentpass_TextChanged);
            // 
            // lblconfirmpass
            // 
            this.lblconfirmpass.Location = new System.Drawing.Point(50, 194);
            this.lblconfirmpass.Name = "lblconfirmpass";
            this.lblconfirmpass.Size = new System.Drawing.Size(125, 22);
            this.lblconfirmpass.TabIndex = 1;
            this.lblconfirmpass.Text = "Confirm Password:";
            this.lblconfirmpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblconfirmpass.Click += new System.EventHandler(this.lblcurrentpass_Click);
            // 
            // lblferroruname
            // 
            this.lblferroruname.AutoSize = true;
            this.lblferroruname.BackColor = System.Drawing.Color.White;
            this.lblferroruname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblferroruname.Location = new System.Drawing.Point(287, 83);
            this.lblferroruname.Name = "lblferroruname";
            this.lblferroruname.Size = new System.Drawing.Size(0, 20);
            this.lblferroruname.TabIndex = 10;
            // 
            // lblferroremail
            // 
            this.lblferroremail.AutoSize = true;
            this.lblferroremail.BackColor = System.Drawing.Color.White;
            this.lblferroremail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblferroremail.Location = new System.Drawing.Point(327, 118);
            this.lblferroremail.Name = "lblferroremail";
            this.lblferroremail.Size = new System.Drawing.Size(0, 20);
            this.lblferroremail.TabIndex = 11;
            // 
            // lblferrorNpass
            // 
            this.lblferrorNpass.AutoSize = true;
            this.lblferrorNpass.BackColor = System.Drawing.Color.White;
            this.lblferrorNpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblferrorNpass.Location = new System.Drawing.Point(317, 156);
            this.lblferrorNpass.Name = "lblferrorNpass";
            this.lblferrorNpass.Size = new System.Drawing.Size(0, 20);
            this.lblferrorNpass.TabIndex = 12;
            // 
            // lblferrorCpass
            // 
            this.lblferrorCpass.AutoSize = true;
            this.lblferrorCpass.BackColor = System.Drawing.Color.White;
            this.lblferrorCpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblferrorCpass.Location = new System.Drawing.Point(317, 193);
            this.lblferrorCpass.Name = "lblferrorCpass";
            this.lblferrorCpass.Size = new System.Drawing.Size(0, 20);
            this.lblferrorCpass.TabIndex = 13;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Apparel_Business_Management.Properties.Resources.GroupCoverPhoto;
            this.ClientSize = new System.Drawing.Size(979, 655);
            this.Controls.Add(this.lblferrorCpass);
            this.Controls.Add(this.lblferrorNpass);
            this.Controls.Add(this.lblferroremail);
            this.Controls.Add(this.lblferroruname);
            this.Controls.Add(this.txtforgetnewpass);
            this.Controls.Add(this.txtforgetconfirmpass);
            this.Controls.Add(this.txtforgetemail);
            this.Controls.Add(this.txtforgetuname);
            this.Controls.Add(this.btnforgetback);
            this.Controls.Add(this.btnforgetsubmit);
            this.Controls.Add(this.lblforgetemail);
            this.Controls.Add(this.lblnewpass);
            this.Controls.Add(this.lblconfirmpass);
            this.Controls.Add(this.lblfrogetuname);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrogetuname;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.Label lblforgetemail;
        private System.Windows.Forms.Button btnforgetsubmit;
        private System.Windows.Forms.Button btnforgetback;
        private System.Windows.Forms.TextBox txtforgetuname;
        private System.Windows.Forms.TextBox txtforgetemail;
        private System.Windows.Forms.TextBox txtforgetnewpass;
        private System.Windows.Forms.TextBox txtforgetconfirmpass;
        private System.Windows.Forms.Label lblconfirmpass;
        private System.Windows.Forms.Label lblferroruname;
        private System.Windows.Forms.Label lblferroremail;
        private System.Windows.Forms.Label lblferrorNpass;
        private System.Windows.Forms.Label lblferrorCpass;
    }
}