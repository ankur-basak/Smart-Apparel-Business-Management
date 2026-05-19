namespace Smart_Apparel_Business_Management
{
    partial class HRSettings
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
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAccountSettings.Location = new System.Drawing.Point(239, 44);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(158, 53);
            this.btnAccountSettings.TabIndex = 1;
            this.btnAccountSettings.Text = "Update Profile";
            this.btnAccountSettings.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReports.Location = new System.Drawing.Point(73, 44);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(141, 53);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Change Password";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(403, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HRSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAccountSettings);
            this.Controls.Add(this.btnReports);
            this.Name = "HRSettings";
            this.Text = "HRSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button button1;
    }
}