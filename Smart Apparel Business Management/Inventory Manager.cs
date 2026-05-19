using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    
    public partial class Inventory_Manager : Form
    {
        public int idManager = 1;
        public Inventory_Manager(int id)
        {
            this.idManager = id;  
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            View_Products vp = new View_Products(this);

            vp.Visible = true;




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnci_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btninop_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inventory_operation op = new Inventory_operation(this);
            op.Visible = true;
        }

        private void btnvir_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            View_Inventory_reports ir = new View_Inventory_reports(this);
            ir.Visible= true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditProfile ep = new EditProfile(this, idManager);
            ep.Visible = true;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login log = new Login();
            log.Visible= true;

        }
    }
}
