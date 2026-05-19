namespace Smart_Apparel_Business_Management
{
    partial class SalesExceutive
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
            this.lblSalesExecutiveTitle = new System.Windows.Forms.Label();
            this.btnViewDasboard = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnOrderOP = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnSlogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalesExecutiveTitle
            // 
            this.lblSalesExecutiveTitle.AutoSize = true;
            this.lblSalesExecutiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesExecutiveTitle.Location = new System.Drawing.Point(162, 30);
            this.lblSalesExecutiveTitle.Name = "lblSalesExecutiveTitle";
            this.lblSalesExecutiveTitle.Size = new System.Drawing.Size(350, 31);
            this.lblSalesExecutiveTitle.TabIndex = 1;
            this.lblSalesExecutiveTitle.Text = "Welcome,Sales Executive";
            this.lblSalesExecutiveTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnViewDasboard
            // 
            this.btnViewDasboard.AutoSize = true;
            this.btnViewDasboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDasboard.Location = new System.Drawing.Point(211, 91);
            this.btnViewDasboard.Name = "btnViewDasboard";
            this.btnViewDasboard.Size = new System.Drawing.Size(263, 47);
            this.btnViewDasboard.TabIndex = 2;
            this.btnViewDasboard.Text = "View Dashboard";
            this.btnViewDasboard.UseVisualStyleBackColor = true;
            this.btnViewDasboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.AutoSize = true;
            this.btnViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProduct.Location = new System.Drawing.Point(211, 313);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(196, 43);
            this.btnViewProduct.TabIndex = 3;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSize = true;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(211, 166);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(211, 43);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOrderOP
            // 
            this.btnOrderOP.AutoSize = true;
            this.btnOrderOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderOP.Location = new System.Drawing.Point(211, 239);
            this.btnOrderOP.Name = "btnOrderOP";
            this.btnOrderOP.Size = new System.Drawing.Size(236, 43);
            this.btnOrderOP.TabIndex = 5;
            this.btnOrderOP.Text = "Order Operation";
            this.btnOrderOP.UseVisualStyleBackColor = true;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.AutoSize = true;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.Location = new System.Drawing.Point(211, 381);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(186, 43);
            this.btnPrintInvoice.TabIndex = 10;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // btnSlogout
            // 
            this.btnSlogout.Location = new System.Drawing.Point(461, 434);
            this.btnSlogout.Name = "btnSlogout";
            this.btnSlogout.Size = new System.Drawing.Size(75, 23);
            this.btnSlogout.TabIndex = 12;
            this.btnSlogout.Text = "Logout";
            this.btnSlogout.UseVisualStyleBackColor = true;
            this.btnSlogout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnSlogout);
            this.panel1.Controls.Add(this.btnPrintInvoice);
            this.panel1.Controls.Add(this.btnOrderOP);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.btnViewProduct);
            this.panel1.Controls.Add(this.btnViewDasboard);
            this.panel1.Controls.Add(this.lblSalesExecutiveTitle);
            this.panel1.Location = new System.Drawing.Point(-12, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 494);
            this.panel1.TabIndex = 0;
            // 
            // SalesExceutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 482);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesExceutive";
            this.Text = "SalesExcutive";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSalesExecutiveTitle;
        private System.Windows.Forms.Button btnViewDasboard;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnOrderOP;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnSlogout;
        private System.Windows.Forms.Panel panel1;
    }
}