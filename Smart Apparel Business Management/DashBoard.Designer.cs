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
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Apparel_Business_Management.Properties.Resources.Launching_Poster;
            this.ClientSize = new System.Drawing.Size(1382, 844);
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
    }
}