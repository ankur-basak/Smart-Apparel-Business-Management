namespace Smart_Apparel_Business_Management
{
    partial class HR_WorkforceManagement
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
            this.btnUpE = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpE
            // 
            this.btnUpE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpE.Location = new System.Drawing.Point(261, 40);
            this.btnUpE.Name = "btnUpE";
            this.btnUpE.Size = new System.Drawing.Size(150, 43);
            this.btnUpE.TabIndex = 51;
            this.btnUpE.Text = "Leave request";
            this.btnUpE.UseVisualStyleBackColor = true;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(96, 40);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(124, 43);
            this.btnAddEmp.TabIndex = 50;
            this.btnAddEmp.Text = "Attendance";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(436, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 53);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // HR_WorkforceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1004, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpE);
            this.Controls.Add(this.btnAddEmp);
            this.Name = "HR_WorkforceManagement";
            this.Text = "HR_WorkforceManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpE;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnBack;
    }
}