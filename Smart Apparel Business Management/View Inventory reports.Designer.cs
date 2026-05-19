namespace clothingstore
{
    partial class View_Inventory_reports
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
            this.gvir = new System.Windows.Forms.DataGridView();
            this.btnbk = new System.Windows.Forms.Button();
            this.lblmnvi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvir)).BeginInit();
            this.SuspendLayout();
            // 
            // gvir
            // 
            this.gvir.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.gvir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvir.Location = new System.Drawing.Point(130, 145);
            this.gvir.Name = "gvir";
            this.gvir.RowHeadersWidth = 62;
            this.gvir.RowTemplate.Height = 28;
            this.gvir.Size = new System.Drawing.Size(962, 347);
            this.gvir.TabIndex = 0;
            // 
            // btnbk
            // 
            this.btnbk.BackColor = System.Drawing.Color.Magenta;
            this.btnbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbk.Location = new System.Drawing.Point(552, 542);
            this.btnbk.Name = "btnbk";
            this.btnbk.Size = new System.Drawing.Size(125, 63);
            this.btnbk.TabIndex = 2;
            this.btnbk.Text = "Back";
            this.btnbk.UseVisualStyleBackColor = false;
            this.btnbk.Click += new System.EventHandler(this.btnbk_Click);
            // 
            // lblmnvi
            // 
            this.lblmnvi.AutoSize = true;
            this.lblmnvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmnvi.Location = new System.Drawing.Point(515, 69);
            this.lblmnvi.Name = "lblmnvi";
            this.lblmnvi.Size = new System.Drawing.Size(198, 20);
            this.lblmnvi.TabIndex = 3;
            this.lblmnvi.Text = "Report Of the Inventory";
            // 
            // View_Inventory_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1226, 654);
            this.Controls.Add(this.lblmnvi);
            this.Controls.Add(this.btnbk);
            this.Controls.Add(this.gvir);
            this.Name = "View_Inventory_reports";
            this.Text = "View_Inventory_reports";
            ((System.ComponentModel.ISupportInitialize)(this.gvir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvir;
        private System.Windows.Forms.Button btnbk;
        private System.Windows.Forms.Label lblmnvi;
    }
}