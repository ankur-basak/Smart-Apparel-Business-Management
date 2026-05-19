namespace Smart_Apparel_Business_Management
{
    partial class reports
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
            this.BtnSR = new System.Windows.Forms.Button();
            this.BtnHR = new System.Windows.Forms.Button();
            this.btnIR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSR
            // 
            this.BtnSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSR.Location = new System.Drawing.Point(39, 22);
            this.BtnSR.Name = "BtnSR";
            this.BtnSR.Size = new System.Drawing.Size(143, 42);
            this.BtnSR.TabIndex = 0;
            this.BtnSR.Text = "Sales Reports";
            this.BtnSR.UseVisualStyleBackColor = true;
            this.BtnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // BtnHR
            // 
            this.BtnHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnHR.Location = new System.Drawing.Point(299, 22);
            this.BtnHR.Name = "BtnHR";
            this.BtnHR.Size = new System.Drawing.Size(143, 42);
            this.BtnHR.TabIndex = 0;
            this.BtnHR.Text = "HR Reports";
            this.BtnHR.UseVisualStyleBackColor = true;
            this.BtnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnIR
            // 
            this.btnIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIR.Location = new System.Drawing.Point(563, 22);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(158, 42);
            this.btnIR.TabIndex = 0;
            this.btnIR.Text = "Inventory Reports";
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(837, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1048, 587);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnHR);
            this.Controls.Add(this.BtnSR);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSR;
        private System.Windows.Forms.Button BtnHR;
        private System.Windows.Forms.Button btnIR;
        private System.Windows.Forms.Button button1;
    }
}