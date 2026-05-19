using System;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
            this.Load += ViewProduct_Load;
            btnBack2.Click += btnBack2_Click;
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.DataSource = SalesDataStore.GetProductsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product load error:\n" + ex.Message);
            }
        }

        private void btnBack2_Click(object sender, EventArgs e) { this.Close(); }
    }
}
