namespace Smart_Apparel_Business_Management
{
    partial class ViewDashboard
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
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblTotalCustomer = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblShowProduct = new System.Windows.Forms.Label();
            this.lblShowCustomers = new System.Windows.Forms.Label();
            this.lblShowSales = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDASHBOARD = new System.Windows.Forms.Label();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.Location = new System.Drawing.Point(55, 95);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(158, 26);
            this.lblTotalProducts.TabIndex = 0;
            this.lblTotalProducts.Text = "Total Products :";
            // 
            // lblTotalCustomer
            // 
            this.lblTotalCustomer.AutoSize = true;
            this.lblTotalCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomer.Location = new System.Drawing.Point(55, 155);
            this.lblTotalCustomer.Name = "lblTotalCustomer";
            this.lblTotalCustomer.Size = new System.Drawing.Size(175, 26);
            this.lblTotalCustomer.TabIndex = 1;
            this.lblTotalCustomer.Text = "Total Customers :";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(55, 209);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(127, 26);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.Text = "Total Sales :";
            // 
            // lblShowProduct
            // 
            this.lblShowProduct.AutoSize = true;
            this.lblShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowProduct.Location = new System.Drawing.Point(272, 97);
            this.lblShowProduct.Name = "lblShowProduct";
            this.lblShowProduct.Size = new System.Drawing.Size(20, 24);
            this.lblShowProduct.TabIndex = 3;
            this.lblShowProduct.Text = "0";
            // 
            // lblShowCustomers
            // 
            this.lblShowCustomers.AutoSize = true;
            this.lblShowCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCustomers.Location = new System.Drawing.Point(272, 157);
            this.lblShowCustomers.Name = "lblShowCustomers";
            this.lblShowCustomers.Size = new System.Drawing.Size(20, 24);
            this.lblShowCustomers.TabIndex = 4;
            this.lblShowCustomers.Text = "0";
            this.lblShowCustomers.Click += new System.EventHandler(this.lblShowCustomers_Click);
            // 
            // lblShowSales
            // 
            this.lblShowSales.AutoSize = true;
            this.lblShowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSales.Location = new System.Drawing.Point(272, 211);
            this.lblShowSales.Name = "lblShowSales";
            this.lblShowSales.Size = new System.Drawing.Size(20, 24);
            this.lblShowSales.TabIndex = 5;
            this.lblShowSales.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lblDASHBOARD);
            this.panel1.Location = new System.Drawing.Point(-9, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 50);
            this.panel1.TabIndex = 6;
            // 
            // lblDASHBOARD
            // 
            this.lblDASHBOARD.AutoSize = true;
            this.lblDASHBOARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDASHBOARD.Location = new System.Drawing.Point(179, 12);
            this.lblDASHBOARD.Name = "lblDASHBOARD";
            this.lblDASHBOARD.Size = new System.Drawing.Size(153, 25);
            this.lblDASHBOARD.TabIndex = 0;
            this.lblDASHBOARD.Text = "DASHBOARD";
            // 
            // btnBack1
            // 
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.Location = new System.Drawing.Point(396, 270);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(75, 23);
            this.btnBack1.TabIndex = 7;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            // 
            // ViewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(499, 321);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblShowSales);
            this.Controls.Add(this.lblShowCustomers);
            this.Controls.Add(this.lblShowProduct);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblTotalCustomer);
            this.Controls.Add(this.lblTotalProducts);
            this.Name = "ViewDashboard";
            this.Text = "View Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblTotalCustomer;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblShowProduct;
        private System.Windows.Forms.Label lblShowCustomers;
        private System.Windows.Forms.Label lblShowSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDASHBOARD;
        private System.Windows.Forms.Button btnBack1;
    }
}