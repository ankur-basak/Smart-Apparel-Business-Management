using Diagnostic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothingstore
{
    public partial class View_Inventory_reports : Form
    {
        public Inventory_Manager im;
        public View_Inventory_reports(Inventory_Manager pre)
        { 
            this.im = pre;
            InitializeComponent();
            LoadInventoryReport();
        }

        private void btnsh_Click(object sender, EventArgs e)
        {

        }

        private void btnbk_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            im.Visible = true;
        }
        private void LoadInventoryReport()
        {
            try
            {
                DataAccess da = new DataAccess();

                string query =
                    "SELECT " +
                    "productId, " +
                    "productName, " +
                    "totalStock, " +
                    "availableStock, " +
                    "CASE " +
                    "WHEN availableStock <= 5 THEN 'Low Stock' " +
                    "WHEN availableStock <= 20 THEN 'Medium Stock' " +
                    "ELSE 'In Stock' " +
                    "END AS StockStatus " +

                    "FROM ProductInventory";

                DataTable dt = da.ExecuteQueryTable(query);

                gvir.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
