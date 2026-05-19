namespace Smart_Apparel_Business_Management
{
    partial class View_Products
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
            this.gvp = new System.Windows.Forms.DataGridView();
            this.lblmng = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvp)).BeginInit();
            this.SuspendLayout();
            // 
            // gvp
            // 
            this.gvp.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.gvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvp.Location = new System.Drawing.Point(27, 90);
            this.gvp.Name = "gvp";
            this.gvp.RowHeadersWidth = 62;
            this.gvp.RowTemplate.Height = 28;
            this.gvp.Size = new System.Drawing.Size(1192, 461);
            this.gvp.TabIndex = 0;
            this.gvp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblmng
            // 
            this.lblmng.AutoSize = true;
            this.lblmng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmng.Location = new System.Drawing.Point(1126, 26);
            this.lblmng.Name = "lblmng";
            this.lblmng.Size = new System.Drawing.Size(87, 26);
            this.lblmng.TabIndex = 1;
            this.lblmng.Text = "Search";
            this.lblmng.Click += new System.EventHandler(this.lblmng_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Red;
            this.btnback.Location = new System.Drawing.Point(1044, 568);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(179, 51);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Lime;
            this.btnshow.Location = new System.Drawing.Point(480, 568);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(203, 51);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(857, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 40);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Product Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1127, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "(by Name)";
            // 
            // View_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblmng);
            this.Controls.Add(this.gvp);
            this.Name = "View_Products";
            this.Text = "View_Products";
            ((System.ComponentModel.ISupportInitialize)(this.gvp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvp;
        private System.Windows.Forms.Label lblmng;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}