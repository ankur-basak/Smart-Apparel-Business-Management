namespace Smart_Apparel_Business_Management
{
    partial class Inventory_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Manager));
            this.btnvir = new System.Windows.Forms.Button();
            this.btnvp = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btninop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvir
            // 
            this.btnvir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnvir.Location = new System.Drawing.Point(579, 153);
            this.btnvir.Name = "btnvir";
            this.btnvir.Size = new System.Drawing.Size(191, 167);
            this.btnvir.TabIndex = 2;
            this.btnvir.Text = "View Inventory Reports";
            this.btnvir.UseVisualStyleBackColor = false;
            this.btnvir.Click += new System.EventHandler(this.btnvir_Click);
            // 
            // btnvp
            // 
            this.btnvp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnvp.Location = new System.Drawing.Point(346, 153);
            this.btnvp.Name = "btnvp";
            this.btnvp.Size = new System.Drawing.Size(139, 167);
            this.btnvp.TabIndex = 7;
            this.btnvp.Text = "View Products";
            this.btnvp.UseVisualStyleBackColor = false;
            this.btnvp.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.Location = new System.Drawing.Point(3, 554);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(121, 65);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btninop
            // 
            this.btninop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btninop.Location = new System.Drawing.Point(81, 153);
            this.btninop.Name = "btninop";
            this.btninop.Size = new System.Drawing.Size(162, 167);
            this.btninop.TabIndex = 10;
            this.btninop.Text = "Inventory Operation";
            this.btninop.UseVisualStyleBackColor = false;
            this.btninop.Click += new System.EventHandler(this.btninop_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(804, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btninop);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnvp);
            this.Controls.Add(this.btnvir);
            this.Name = "Inventory_Manager";
            this.Text = "Inventory_Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnvir;
        private System.Windows.Forms.Button btnvp;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btninop;
        private System.Windows.Forms.Button button1;
    }
}