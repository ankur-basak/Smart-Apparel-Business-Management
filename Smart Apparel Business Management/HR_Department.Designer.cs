namespace Smart_Apparel_Business_Management
{
    partial class HR_Department
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
            this.btnHROperation = new System.Windows.Forms.Button();
            this.btnWM = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHROperation
            // 
            this.btnHROperation.Location = new System.Drawing.Point(73, 42);
            this.btnHROperation.Name = "btnHROperation";
            this.btnHROperation.Size = new System.Drawing.Size(141, 53);
            this.btnHROperation.TabIndex = 0;
            this.btnHROperation.Text = "HR Operation";
            this.btnHROperation.UseVisualStyleBackColor = true;
            // 
            // btnWM
            // 
            this.btnWM.Location = new System.Drawing.Point(248, 42);
            this.btnWM.Name = "btnWM";
            this.btnWM.Size = new System.Drawing.Size(161, 53);
            this.btnWM.TabIndex = 0;
            this.btnWM.Text = "Workforce Management";
            this.btnWM.UseVisualStyleBackColor = true;
            this.btnWM.Click += new System.EventHandler(this.btnWM_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(448, 42);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(141, 53);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Genarate Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.Location = new System.Drawing.Point(614, 42);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(158, 53);
            this.btnAccountSettings.TabIndex = 0;
            this.btnAccountSettings.Text = " Account Settings";
            this.btnAccountSettings.UseVisualStyleBackColor = true;
            // 
            // btnlogOut
            // 
            this.btnlogOut.Location = new System.Drawing.Point(382, 325);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(122, 48);
            this.btnlogOut.TabIndex = 1;
            this.btnlogOut.Text = "Log out";
            this.btnlogOut.UseVisualStyleBackColor = true;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // HR_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(902, 472);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.btnWM);
            this.Controls.Add(this.btnAccountSettings);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnHROperation);
            this.Name = "HR_Department";
            this.Text = "HR_Department";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHROperation;
        private System.Windows.Forms.Button btnWM;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Button btnlogOut;
    }
}