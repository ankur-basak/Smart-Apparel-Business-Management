namespace SmartClothingBusiness
{
    partial class HRDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnLeave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(580, 50);
            this.lblTitle.Text = "Smart Clothing Business - HR Dashboard";

            this.btnHR.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnHR.ForeColor = System.Drawing.Color.White;
            this.btnHR.Location = new System.Drawing.Point(80, 140);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(220, 120);
            this.btnHR.Text = "Manage HR";
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);

            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(330, 140);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(220, 120);
            this.btnAttendance.Text = "Manage Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);

            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.Location = new System.Drawing.Point(580, 140);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(220, 120);
            this.btnLeave.Text = "Manage Leave Requests";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnLeave);
            this.Name = "HRDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
