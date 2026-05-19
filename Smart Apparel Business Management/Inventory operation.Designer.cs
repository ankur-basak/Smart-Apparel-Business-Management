namespace clothingstore
{
    partial class Inventory_operation
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
            this.btnap = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnrp = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpid = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblbnd = new System.Windows.Forms.Label();
            this.lblqnt = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.lblclr = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.cbdn = new System.Windows.Forms.CheckBox();
            this.cbads = new System.Windows.Forms.CheckBox();
            this.cbnk = new System.Windows.Forms.CheckBox();
            this.cmbsize = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbt = new System.Windows.Forms.RadioButton();
            this.rbcp = new System.Windows.Forms.RadioButton();
            this.rbfp = new System.Windows.Forms.RadioButton();
            this.rbfs = new System.Windows.Forms.RadioButton();
            this.gvio = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnap
            // 
            this.btnap.BackColor = System.Drawing.Color.Yellow;
            this.btnap.Location = new System.Drawing.Point(21, 337);
            this.btnap.Name = "btnap";
            this.btnap.Size = new System.Drawing.Size(160, 60);
            this.btnap.TabIndex = 0;
            this.btnap.Text = "Add Product";
            this.btnap.UseVisualStyleBackColor = false;
            this.btnap.Click += new System.EventHandler(this.btnap_Click);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.Lime;
            this.btnup.Location = new System.Drawing.Point(218, 337);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(187, 60);
            this.btnup.TabIndex = 1;
            this.btnup.Text = "Update Product";
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnrp
            // 
            this.btnrp.BackColor = System.Drawing.Color.Cyan;
            this.btnrp.Location = new System.Drawing.Point(454, 337);
            this.btnrp.Name = "btnrp";
            this.btnrp.Size = new System.Drawing.Size(202, 60);
            this.btnrp.TabIndex = 2;
            this.btnrp.Text = "Remove Product";
            this.btnrp.UseVisualStyleBackColor = false;
            this.btnrp.Click += new System.EventHandler(this.btnrp_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnback.Location = new System.Drawing.Point(842, 337);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(133, 60);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(58, 61);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(89, 20);
            this.lblpid.TabIndex = 7;
            this.lblpid.Text = "Product ID:";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(596, 123);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(48, 20);
            this.lblsize.TabIndex = 8;
            this.lblsize.Text = "Size :";
            this.lblsize.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblbnd
            // 
            this.lblbnd.AutoSize = true;
            this.lblbnd.Location = new System.Drawing.Point(584, 62);
            this.lblbnd.Name = "lblbnd";
            this.lblbnd.Size = new System.Drawing.Size(60, 20);
            this.lblbnd.TabIndex = 9;
            this.lblbnd.Text = "Brand :";
            this.lblbnd.Click += new System.EventHandler(this.lblbnd_Click);
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.Location = new System.Drawing.Point(58, 288);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(76, 20);
            this.lblqnt.TabIndex = 10;
            this.lblqnt.Text = "Quantity :";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Location = new System.Drawing.Point(58, 192);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(81, 20);
            this.lblcat.TabIndex = 11;
            this.lblcat.Text = "Category :";
            this.lblcat.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Location = new System.Drawing.Point(58, 126);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(110, 20);
            this.lblpname.TabIndex = 12;
            this.lblpname.Text = "Product Name";
            // 
            // lblclr
            // 
            this.lblclr.AutoSize = true;
            this.lblclr.Location = new System.Drawing.Point(593, 195);
            this.lblclr.Name = "lblclr";
            this.lblclr.Size = new System.Drawing.Size(54, 20);
            this.lblclr.TabIndex = 13;
            this.lblclr.Text = "Color :";
            this.lblclr.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(174, 55);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(295, 26);
            this.txtpid.TabIndex = 14;
            // 
            // txtqnt
            // 
            this.txtqnt.Location = new System.Drawing.Point(174, 285);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(295, 26);
            this.txtqnt.TabIndex = 18;
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(174, 120);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(295, 26);
            this.txtpname.TabIndex = 20;
            // 
            // cbdn
            // 
            this.cbdn.AutoSize = true;
            this.cbdn.Location = new System.Drawing.Point(678, 61);
            this.cbdn.Name = "cbdn";
            this.cbdn.Size = new System.Drawing.Size(81, 24);
            this.cbdn.TabIndex = 21;
            this.cbdn.Text = "Denim";
            this.cbdn.UseVisualStyleBackColor = true;
            // 
            // cbads
            // 
            this.cbads.AutoSize = true;
            this.cbads.Location = new System.Drawing.Point(972, 60);
            this.cbads.Name = "cbads";
            this.cbads.Size = new System.Drawing.Size(84, 24);
            this.cbads.TabIndex = 22;
            this.cbads.Text = "Adidas";
            this.cbads.UseVisualStyleBackColor = true;
            // 
            // cbnk
            // 
            this.cbnk.AutoSize = true;
            this.cbnk.Location = new System.Drawing.Point(822, 60);
            this.cbnk.Name = "cbnk";
            this.cbnk.Size = new System.Drawing.Size(66, 24);
            this.cbnk.TabIndex = 23;
            this.cbnk.Text = "Nike";
            this.cbnk.UseVisualStyleBackColor = true;
            // 
            // cmbsize
            // 
            this.cmbsize.FormattingEnabled = true;
            this.cmbsize.Items.AddRange(new object[] {
            "S (34)",
            "M (36)",
            "L (38)",
            "XL (40)",
            "XXL (42)",
            "XXXL (44-46)"});
            this.cmbsize.Location = new System.Drawing.Point(678, 120);
            this.cmbsize.Name = "cmbsize";
            this.cmbsize.Size = new System.Drawing.Size(316, 28);
            this.cmbsize.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "White",
            "Black",
            "Blue",
            "Aqua",
            "Nevy",
            "Ivory",
            "Ash"});
            this.comboBox1.Location = new System.Drawing.Point(678, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // rbt
            // 
            this.rbt.AutoSize = true;
            this.rbt.Location = new System.Drawing.Point(174, 187);
            this.rbt.Name = "rbt";
            this.rbt.Size = new System.Drawing.Size(81, 24);
            this.rbt.TabIndex = 26;
            this.rbt.TabStop = true;
            this.rbt.Text = "T-Shirt";
            this.rbt.UseVisualStyleBackColor = true;
            // 
            // rbcp
            // 
            this.rbcp.AutoSize = true;
            this.rbcp.Location = new System.Drawing.Point(318, 230);
            this.rbcp.Name = "rbcp";
            this.rbcp.Size = new System.Drawing.Size(120, 24);
            this.rbcp.TabIndex = 29;
            this.rbcp.TabStop = true;
            this.rbcp.Text = "Casual Pant";
            this.rbcp.UseVisualStyleBackColor = true;
            // 
            // rbfp
            // 
            this.rbfp.AutoSize = true;
            this.rbfp.Location = new System.Drawing.Point(174, 230);
            this.rbfp.Name = "rbfp";
            this.rbfp.Size = new System.Drawing.Size(120, 24);
            this.rbfp.TabIndex = 30;
            this.rbfp.TabStop = true;
            this.rbfp.Text = "Formal Pant";
            this.rbfp.UseVisualStyleBackColor = true;
            // 
            // rbfs
            // 
            this.rbfs.AutoSize = true;
            this.rbfs.Location = new System.Drawing.Point(318, 188);
            this.rbfs.Name = "rbfs";
            this.rbfs.Size = new System.Drawing.Size(120, 24);
            this.rbfs.TabIndex = 31;
            this.rbfs.TabStop = true;
            this.rbfs.Text = "Formal Shirt";
            this.rbfs.UseVisualStyleBackColor = true;
            // 
            // gvio
            // 
            this.gvio.BackgroundColor = System.Drawing.Color.Bisque;
            this.gvio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvio.Location = new System.Drawing.Point(-13, 425);
            this.gvio.Name = "gvio";
            this.gvio.RowHeadersWidth = 62;
            this.gvio.RowTemplate.Height = 28;
            this.gvio.Size = new System.Drawing.Size(1309, 307);
            this.gvio.TabIndex = 32;
            this.gvio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvio_CellClick);
            this.gvio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvio_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(678, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 60);
            this.button1.TabIndex = 33;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory_operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 809);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvio);
            this.Controls.Add(this.rbfs);
            this.Controls.Add(this.rbfp);
            this.Controls.Add(this.rbcp);
            this.Controls.Add(this.rbt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbsize);
            this.Controls.Add(this.cbnk);
            this.Controls.Add(this.cbads);
            this.Controls.Add(this.cbdn);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.txtqnt);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.lblclr);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.lblbnd);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnrp);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnap);
            this.Name = "Inventory_operation";
            this.Text = "Inventory_operation";
            this.Load += new System.EventHandler(this.Inventory_operation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnap;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnrp;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblbnd;
        private System.Windows.Forms.Label lblqnt;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblclr;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.CheckBox cbdn;
        private System.Windows.Forms.CheckBox cbads;
        private System.Windows.Forms.CheckBox cbnk;
        private System.Windows.Forms.ComboBox cmbsize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbt;
        private System.Windows.Forms.RadioButton rbcp;
        private System.Windows.Forms.RadioButton rbfp;
        private System.Windows.Forms.RadioButton rbfs;
        private System.Windows.Forms.DataGridView gvio;
        private System.Windows.Forms.Button button1;
    }
}