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
    public partial class View_Products : Form
    {
        public Inventory_Manager im;
        public View_Products(Inventory_Manager pre)
        {
            this.im = pre;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                DataAccess da = new DataAccess();

                string sql = "SELECT * FROM ProductInventory";

                DataTable dt = da.ExecuteQueryTable(sql);

                gvp.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            im.Visible = true;
        }

        private void lblmng_Click(object sender, EventArgs e)
        {
          
            try
            {
                DataAccess da = new DataAccess();

                string searchText = textBox1.Text;

                string query = "SELECT * FROM ProductInventory " +
                               "WHERE productName LIKE '%" + searchText + "%' " +
                               "OR category LIKE '%" + searchText + "%' " +
                               "OR brand LIKE '%" + searchText + "%'";

                DataTable dt = da.ExecuteQueryTable(query);

                gvp.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }
    }
}
