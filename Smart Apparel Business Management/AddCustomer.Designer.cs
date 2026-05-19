namespace Smart_Apparel_Business_Management
{
    partial class AddCustomer
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
            this.llblCname = new System.Windows.Forms.Label();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCemail = new System.Windows.Forms.Label();
            this.lbladdcustomer = new System.Windows.Forms.Label();
            this.txtCbox1 = new System.Windows.Forms.TextBox();
            this.txtCbox2 = new System.Windows.Forms.TextBox();
            this.txtCbox3 = new System.Windows.Forms.TextBox();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnaddC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llblCname
            // 
            this.llblCname.AutoSize = true;
            this.llblCname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCname.Location = new System.Drawing.Point(73, 119);
            this.llblCname.Name = "llblCname";
            this.llblCname.Size = new System.Drawing.Size(59, 20);
            this.llblCname.TabIndex = 0;
            this.llblCname.Text = "Name :";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhone.Location = new System.Drawing.Point(73, 170);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(63, 20);
            this.lblCPhone.TabIndex = 1;
            this.lblCPhone.Text = "Phone :";
            // 
            // lblCemail
            // 
            this.lblCemail.AutoSize = true;
            this.lblCemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCemail.Location = new System.Drawing.Point(74, 215);
            this.lblCemail.Name = "lblCemail";
            this.lblCemail.Size = new System.Drawing.Size(56, 20);
            this.lblCemail.TabIndex = 2;
            this.lblCemail.Text = "Email :";
            this.lblCemail.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbladdcustomer
            // 
            this.lbladdcustomer.AutoSize = true;
            this.lbladdcustomer.BackColor = System.Drawing.Color.FloralWhite;
            this.lbladdcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdcustomer.Location = new System.Drawing.Point(119, 36);
            this.lbladdcustomer.Name = "lbladdcustomer";
            this.lbladdcustomer.Size = new System.Drawing.Size(218, 29);
            this.lbladdcustomer.TabIndex = 3;
            this.lbladdcustomer.Text = "ADD CUSTOMER";
            // 
            // txtCbox1
            // 
            this.txtCbox1.Location = new System.Drawing.Point(138, 119);
            this.txtCbox1.Name = "txtCbox1";
            this.txtCbox1.Size = new System.Drawing.Size(308, 20);
            this.txtCbox1.TabIndex = 4;
            // 
            // txtCbox2
            // 
            this.txtCbox2.Location = new System.Drawing.Point(138, 170);
            this.txtCbox2.Name = "txtCbox2";
            this.txtCbox2.Size = new System.Drawing.Size(308, 20);
            this.txtCbox2.TabIndex = 5;
            // 
            // txtCbox3
            // 
            this.txtCbox3.Location = new System.Drawing.Point(136, 215);
            this.txtCbox3.Name = "txtCbox3";
            this.txtCbox3.Size = new System.Drawing.Size(308, 20);
            this.txtCbox3.TabIndex = 6;
            // 
            // btnBack3
            // 
            this.btnBack3.Location = new System.Drawing.Point(371, 276);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(75, 23);
            this.btnBack3.TabIndex = 7;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            // 
            // btnaddC
            // 
            this.btnaddC.Location = new System.Drawing.Point(136, 252);
            this.btnaddC.Name = "btnaddC";
            this.btnaddC.Size = new System.Drawing.Size(75, 23);
            this.btnaddC.TabIndex = 8;
            this.btnaddC.Text = "Add";
            this.btnaddC.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(475, 311);
            this.Controls.Add(this.btnaddC);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.txtCbox3);
            this.Controls.Add(this.txtCbox2);
            this.Controls.Add(this.txtCbox1);
            this.Controls.Add(this.lbladdcustomer);
            this.Controls.Add(this.lblCemail);
            this.Controls.Add(this.lblCPhone);
            this.Controls.Add(this.llblCname);
            this.Name = "AddCustomer";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llblCname;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCemail;
        private System.Windows.Forms.Label lbladdcustomer;
        private System.Windows.Forms.TextBox txtCbox1;
        private System.Windows.Forms.TextBox txtCbox2;
        private System.Windows.Forms.TextBox txtCbox3;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnaddC;
    }
}