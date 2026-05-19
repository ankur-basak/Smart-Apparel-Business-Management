namespace Smart_Apparel_Business_Management
{
    partial class Login
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
            this.lbluname = new System.Windows.Forms.Label();
            this.lblupass = new System.Windows.Forms.Label();
            this.btulogin = new System.Windows.Forms.Button();
            this.btusignup = new System.Windows.Forms.Button();
            this.btnforgetpass = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtupass = new System.Windows.Forms.TextBox();
            this.lblutitle = new System.Windows.Forms.Label();
            this.lblerrormsguname = new System.Windows.Forms.Label();
            this.lblerrorupass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbluname
            // 
            this.lbluname.BackColor = System.Drawing.Color.DarkSalmon;
            this.lbluname.Location = new System.Drawing.Point(24, 77);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(116, 26);
            this.lbluname.TabIndex = 0;
            this.lbluname.Text = "Username:";
            this.lbluname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblupass
            // 
            this.lblupass.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblupass.Location = new System.Drawing.Point(24, 120);
            this.lblupass.Name = "lblupass";
            this.lblupass.Size = new System.Drawing.Size(116, 26);
            this.lblupass.TabIndex = 1;
            this.lblupass.Text = "Password:";
            this.lblupass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btulogin
            // 
            this.btulogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btulogin.Location = new System.Drawing.Point(42, 169);
            this.btulogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btulogin.Name = "btulogin";
            this.btulogin.Size = new System.Drawing.Size(98, 26);
            this.btulogin.TabIndex = 2;
            this.btulogin.Text = "Login";
            this.btulogin.UseVisualStyleBackColor = false;
            this.btulogin.Click += new System.EventHandler(this.btulogin_Click);
            // 
            // btusignup
            // 
            this.btusignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btusignup.Location = new System.Drawing.Point(145, 169);
            this.btusignup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btusignup.Name = "btusignup";
            this.btusignup.Size = new System.Drawing.Size(98, 26);
            this.btusignup.TabIndex = 3;
            this.btusignup.Text = "SignUp";
            this.btusignup.UseVisualStyleBackColor = false;
            this.btusignup.Click += new System.EventHandler(this.btusignup_Click);
            // 
            // btnforgetpass
            // 
            this.btnforgetpass.BackColor = System.Drawing.SystemColors.Info;
            this.btnforgetpass.Location = new System.Drawing.Point(22, 199);
            this.btnforgetpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnforgetpass.Name = "btnforgetpass";
            this.btnforgetpass.Size = new System.Drawing.Size(133, 26);
            this.btnforgetpass.TabIndex = 4;
            this.btnforgetpass.Text = "Forget Password";
            this.btnforgetpass.UseVisualStyleBackColor = false;
            this.btnforgetpass.Click += new System.EventHandler(this.btnforgetpass_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.IndianRed;
            this.btnback.Location = new System.Drawing.Point(161, 199);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(98, 26);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(154, 79);
            this.txtuname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(125, 22);
            this.txtuname.TabIndex = 6;
            this.txtuname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtupass
            // 
            this.txtupass.Location = new System.Drawing.Point(154, 125);
            this.txtupass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtupass.Name = "txtupass";
            this.txtupass.PasswordChar = '*';
            this.txtupass.Size = new System.Drawing.Size(125, 22);
            this.txtupass.TabIndex = 7;
            // 
            // lblutitle
            // 
            this.lblutitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblutitle.Location = new System.Drawing.Point(90, 38);
            this.lblutitle.Name = "lblutitle";
            this.lblutitle.Size = new System.Drawing.Size(124, 20);
            this.lblutitle.TabIndex = 8;
            this.lblutitle.Text = "The Trendy Tees";
            // 
            // lblerrormsguname
            // 
            this.lblerrormsguname.AutoSize = true;
            this.lblerrormsguname.BackColor = System.Drawing.Color.White;
            this.lblerrormsguname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblerrormsguname.Location = new System.Drawing.Point(286, 80);
            this.lblerrormsguname.Name = "lblerrormsguname";
            this.lblerrormsguname.Size = new System.Drawing.Size(0, 16);
            this.lblerrormsguname.TabIndex = 9;
            // 
            // lblerrorupass
            // 
            this.lblerrorupass.AutoSize = true;
            this.lblerrorupass.BackColor = System.Drawing.Color.White;
            this.lblerrorupass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblerrorupass.Location = new System.Drawing.Point(286, 129);
            this.lblerrorupass.Name = "lblerrorupass";
            this.lblerrorupass.Size = new System.Drawing.Size(0, 16);
            this.lblerrorupass.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Apparel_Business_Management.Properties.Resources.webpagePic;
            this.ClientSize = new System.Drawing.Size(1082, 844);
            this.Controls.Add(this.lblerrorupass);
            this.Controls.Add(this.lblerrormsguname);
            this.Controls.Add(this.lblutitle);
            this.Controls.Add(this.txtupass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnforgetpass);
            this.Controls.Add(this.btusignup);
            this.Controls.Add(this.btulogin);
            this.Controls.Add(this.lblupass);
            this.Controls.Add(this.lbluname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblupass;
        private System.Windows.Forms.Button btulogin;
        private System.Windows.Forms.Button btusignup;
        private System.Windows.Forms.Button btnforgetpass;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.Label lblutitle;
        private System.Windows.Forms.Label lblerrormsguname;
        private System.Windows.Forms.Label lblerrorupass;
    }
}

