namespace SmartClothingBusiness
{
    partial class HRForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvHR;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvHR = new System.Windows.Forms.DataGridView();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Text = "HR Management";

            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(30, 85);
            this.panelForm.Size = new System.Drawing.Size(360, 500);

            this.lblEmployeeId.Text = "Employee ID";
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeId.Location = new System.Drawing.Point(20, 25);
            this.lblEmployeeId.AutoSize = true;

            this.txtEmployeeId.Location = new System.Drawing.Point(20, 50);
            this.txtEmployeeId.Size = new System.Drawing.Size(310, 22);

            this.lblFullName.Text = "Full Name";
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(20, 90);
            this.lblFullName.AutoSize = true;

            this.txtFullName.Location = new System.Drawing.Point(20, 115);
            this.txtFullName.Size = new System.Drawing.Size(310, 22);

            this.lblDesignation.Text = "Designation";
            this.lblDesignation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDesignation.Location = new System.Drawing.Point(20, 155);
            this.lblDesignation.AutoSize = true;

            this.txtDesignation.Location = new System.Drawing.Point(20, 180);
            this.txtDesignation.Size = new System.Drawing.Size(310, 22);

            this.lblJoiningDate.Text = "Joining Date";
            this.lblJoiningDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJoiningDate.Location = new System.Drawing.Point(20, 220);
            this.lblJoiningDate.AutoSize = true;

            this.dtpJoiningDate.Location = new System.Drawing.Point(20, 245);
            this.dtpJoiningDate.Size = new System.Drawing.Size(310, 22);

            this.lblSalary.Text = "Salary";
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalary.Location = new System.Drawing.Point(20, 285);
            this.lblSalary.AutoSize = true;

            this.txtSalary.Location = new System.Drawing.Point(20, 310);
            this.txtSalary.Size = new System.Drawing.Size(310, 22);

            this.btnAdd.Text = "Add HR";
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

            this.panelForm.Controls.Add(this.lblEmployeeId);
            this.panelForm.Controls.Add(this.txtEmployeeId);
            this.panelForm.Controls.Add(this.lblFullName);
            this.panelForm.Controls.Add(this.txtFullName);
            this.panelForm.Controls.Add(this.lblDesignation);
            this.panelForm.Controls.Add(this.txtDesignation);
            this.panelForm.Controls.Add(this.lblJoiningDate);
            this.panelForm.Controls.Add(this.dtpJoiningDate);
            this.panelForm.Controls.Add(this.lblSalary);
            this.panelForm.Controls.Add(this.txtSalary);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);

            this.dgvHR.Location = new System.Drawing.Point(420, 85);
            this.dgvHR.Size = new System.Drawing.Size(580, 500);
            this.dgvHR.BackgroundColor = System.Drawing.Color.White;
            this.dgvHR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHR.ReadOnly = true;
            this.dgvHR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHR_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dgvHR);
            this.Name = "HRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Management";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
