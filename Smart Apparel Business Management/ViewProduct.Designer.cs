namespace Smart_Apparel_Business_Management
{
    partial class ViewProduct
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
            this.lblProductlist = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductlist
            // 
            this.lblProductlist.AutoSize = true;
            this.lblProductlist.BackColor = System.Drawing.Color.FloralWhite;
            this.lblProductlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductlist.Location = new System.Drawing.Point(227, 42);
            this.lblProductlist.Name = "lblProductlist";
            this.lblProductlist.Size = new System.Drawing.Size(183, 35);
            this.lblProductlist.TabIndex = 0;
            this.lblProductlist.Text = "Product List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.FloralWhite;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(538, 356);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(75, 23);
            this.btnBack2.TabIndex = 2;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(660, 391);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProductlist);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ViewProduct";
            this.Text = "View Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack2;
    }
}