namespace Smart_Apparel_Business_Management
{
    partial class DashBoard
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
            this.lblwelcomemsg = new System.Windows.Forms.Label();
            this.btnAdminOperation = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcomemsg
            // 
            this.lblwelcomemsg.AutoSize = true;
            this.lblwelcomemsg.Location = new System.Drawing.Point(868, 10);
            this.lblwelcomemsg.Name = "lblwelcomemsg";
            this.lblwelcomemsg.Size = new System.Drawing.Size(44, 16);
            this.lblwelcomemsg.TabIndex = 0;
            this.lblwelcomemsg.Text = "label1";
            this.lblwelcomemsg.Click += new System.EventHandler(this.lblwelcomemsg_Click);
            // 
            // btnAdminOperation
            // 
            this.btnAdminOperation.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdminOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminOperation.Location = new System.Drawing.Point(51, 84);
            this.btnAdminOperation.Name = "btnAdminOperation";
            this.btnAdminOperation.Size = new System.Drawing.Size(255, 62);
            this.btnAdminOperation.TabIndex = 1;
            this.btnAdminOperation.Text = "Admin Operation";
            this.btnAdminOperation.UseVisualStyleBackColor = false;
            this.btnAdminOperation.Click += new System.EventHandler(this.btnAdminOperation_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.Info;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(51, 152);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(255, 62);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.Info;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(51, 220);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(255, 62);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Apparel_Business_Management.Properties.Resources.Launching_Poster;
            this.ClientSize = new System.Drawing.Size(1382, 844);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAdminOperation);
            this.Controls.Add(this.lblwelcomemsg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcomemsg;
        private System.Windows.Forms.Button btnAdminOperation;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSettings;
    }
}