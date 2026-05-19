namespace SmartClothingBusiness
{
    partial class LeaveRequestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvLeave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {

            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvLeave = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeave)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Text = "Leave Request Management";

            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(30, 85);
            this.panelForm.Size = new System.Drawing.Size(360, 500);

            this.txtEmployeeId = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20,50), Size = new System.Drawing.Size(310,22) };
            this.cmbLeaveType = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(20,115), Size = new System.Drawing.Size(310,24), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.cmbLeaveType.Items.AddRange(new object[] { "Sick Leave", "Casual Leave", "Annual Leave", "Emergency Leave" });
            this.cmbLeaveType.SelectedIndex = 0;
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(20,180), Size = new System.Drawing.Size(310,22) };
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(20,245), Size = new System.Drawing.Size(310,22) };
            this.txtReason = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20,310), Size = new System.Drawing.Size(310,22) };
            this.cmbStatus = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(20,350), Size = new System.Drawing.Size(310,24), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "Approved", "Rejected" });
            this.cmbStatus.SelectedIndex = 0;

            this.panelForm.Controls.Add(new System.Windows.Forms.Label { Text = "Employee ID", Location = new System.Drawing.Point(20,25), AutoSize = true });
            this.panelForm.Controls.Add(this.txtEmployeeId);
            this.panelForm.Controls.Add(new System.Windows.Forms.Label { Text = "Leave Type", Location = new System.Drawing.Point(20,90), AutoSize = true });
            this.panelForm.Controls.Add(this.cmbLeaveType);
            this.panelForm.Controls.Add(new System.Windows.Forms.Label { Text = "Start Date", Location = new System.Drawing.Point(20,155), AutoSize = true });
            this.panelForm.Controls.Add(this.dtpStartDate);
            this.panelForm.Controls.Add(new System.Windows.Forms.Label { Text = "End Date", Location = new System.Drawing.Point(20,220), AutoSize = true });
            this.panelForm.Controls.Add(this.dtpEndDate);
            this.panelForm.Controls.Add(new System.Windows.Forms.Label { Text = "Reason", Location = new System.Drawing.Point(20,285), AutoSize = true });
            this.panelForm.Controls.Add(this.txtReason);
            this.panelForm.Controls.Add(new System.Windows.Forms.Label { Text = "Leave Status", Location = new System.Drawing.Point(20,330), AutoSize = true });
            this.panelForm.Controls.Add(this.cmbStatus);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);


            this.btnAdd.Text = "Add";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(20, 365);
            this.btnAdd.Size = new System.Drawing.Size(310, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(20, 410);
            this.btnUpdate.Size = new System.Drawing.Size(310, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(20, 455);
            this.btnDelete.Size = new System.Drawing.Size(310, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.dgvLeave.Location = new System.Drawing.Point(420, 85);
            this.dgvLeave.Size = new System.Drawing.Size(580, 500);
            this.dgvLeave.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeave.ReadOnly = true;
            this.dgvLeave.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeave_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dgvLeave);
            this.Name = "LeaveRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Request Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
