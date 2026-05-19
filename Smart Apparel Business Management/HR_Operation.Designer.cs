namespace Smart_Apparel_Business_Management
{
    partial class HR_Operation
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
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtdob = new System.Windows.Forms.DateTimePicker();
            this.cbdept = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.rbother = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbldept = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblupass = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTerminateEmp = new System.Windows.Forms.Button();
            this.btnUpE = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(611, 122);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(125, 22);
            this.txtphone.TabIndex = 69;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(553, 124);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(49, 16);
            this.lblphone.TabIndex = 68;
            this.lblphone.Text = "Phone:";
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(611, 34);
            this.txtdob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(178, 22);
            this.txtdob.TabIndex = 67;
            this.txtdob.Value = new System.DateTime(2026, 4, 24, 23, 59, 59, 0);
            // 
            // cbdept
            // 
            this.cbdept.FormattingEnabled = true;
            this.cbdept.Items.AddRange(new object[] {
            "Admin",
            "HR",
            "Inventory Manager",
            "Sales Executive",
            "Branch manager"});
            this.cbdept.Location = new System.Drawing.Point(168, 90);
            this.cbdept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdept.Name = "cbdept";
            this.cbdept.Size = new System.Drawing.Size(108, 24);
            this.cbdept.TabIndex = 66;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(166, 122);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(177, 47);
            this.txtaddress.TabIndex = 65;
            this.txtaddress.Text = "";
            // 
            // rbother
            // 
            this.rbother.AutoSize = true;
            this.rbother.Location = new System.Drawing.Point(753, 157);
            this.rbother.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbother.Name = "rbother";
            this.rbother.Size = new System.Drawing.Size(60, 20);
            this.rbother.TabIndex = 64;
            this.rbother.TabStop = true;
            this.rbother.Text = "Other";
            this.rbother.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(674, 156);
            this.rbfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(74, 20);
            this.rbfemale.TabIndex = 63;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(611, 157);
            this.rbmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(58, 20);
            this.rbmale.TabIndex = 62;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(611, 64);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(125, 22);
            this.txtemail.TabIndex = 61;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(611, 90);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(125, 22);
            this.txtpass.TabIndex = 60;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(166, 64);
            this.txtuname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(125, 22);
            this.txtuname.TabIndex = 59;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(166, 38);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(125, 22);
            this.txtname.TabIndex = 58;
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(75, 92);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(80, 16);
            this.lbldept.TabIndex = 57;
            this.lbldept.Text = "Department:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(96, 139);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(61, 16);
            this.lbladdress.TabIndex = 56;
            this.lbladdress.Text = "Address:";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(518, 38);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(84, 16);
            this.lbldob.TabIndex = 55;
            this.lbldob.Text = "Date Of Birth:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(546, 159);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(55, 16);
            this.lblgender.TabIndex = 54;
            this.lblgender.Text = "Gender:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(559, 65);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(44, 16);
            this.lblemail.TabIndex = 53;
            this.lblemail.Text = "Email:";
            // 
            // lblupass
            // 
            this.lblupass.AutoSize = true;
            this.lblupass.Location = new System.Drawing.Point(533, 93);
            this.lblupass.Name = "lblupass";
            this.lblupass.Size = new System.Drawing.Size(70, 16);
            this.lblupass.TabIndex = 52;
            this.lblupass.Text = "Password:";
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Location = new System.Drawing.Point(82, 64);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(73, 16);
            this.lbluname.TabIndex = 51;
            this.lbluname.Text = "Username:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(111, 41);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 16);
            this.lblname.TabIndex = 50;
            this.lblname.Text = "Name:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(753, 244);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 43);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(549, 244);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 43);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(651, 244);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 43);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnTerminateEmp
            // 
            this.btnTerminateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminateEmp.Location = new System.Drawing.Point(377, 244);
            this.btnTerminateEmp.Name = "btnTerminateEmp";
            this.btnTerminateEmp.Size = new System.Drawing.Size(170, 43);
            this.btnTerminateEmp.TabIndex = 45;
            this.btnTerminateEmp.Text = "Terminate Employee";
            this.btnTerminateEmp.UseVisualStyleBackColor = true;
            // 
            // btnUpE
            // 
            this.btnUpE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpE.Location = new System.Drawing.Point(225, 244);
            this.btnUpE.Name = "btnUpE";
            this.btnUpE.Size = new System.Drawing.Size(150, 43);
            this.btnUpE.TabIndex = 49;
            this.btnUpE.Text = "Renew";
            this.btnUpE.UseVisualStyleBackColor = true;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(97, 244);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(124, 43);
            this.btnAddEmp.TabIndex = 44;
            this.btnAddEmp.Text = "Hiring";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 209);
            this.dataGridView1.TabIndex = 70;
            // 
            // HR_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1017, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.cbdept);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.rbother);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblupass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTerminateEmp);
            this.Controls.Add(this.btnUpE);
            this.Controls.Add(this.btnAddEmp);
            this.Name = "HR_Operation";
            this.Text = "HR_Operation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.DateTimePicker txtdob;
        private System.Windows.Forms.ComboBox cbdept;
        private System.Windows.Forms.RichTextBox txtaddress;
        private System.Windows.Forms.RadioButton rbother;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblupass;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTerminateEmp;
        private System.Windows.Forms.Button btnUpE;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}