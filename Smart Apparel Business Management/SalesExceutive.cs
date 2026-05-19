using System;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class SalesExceutive : Form
    {
        public SalesExceutive()
        {
            InitializeComponent();

            btnAddCustomer.Click += btnAddCustomer_Click;
            btnOrderOP.Click += btnOrderOP_Click;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewDashboard dashboard = new ViewDashboard();
            dashboard.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewProduct product = new ViewProduct();
            product.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer customer = new AddCustomer();
            customer.ShowDialog();
        }

        private void btnOrderOP_Click(object sender, EventArgs e)
        {
            OrderOperations order = new OrderOperations();
            order.ShowDialog();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            printInvoice invoice = new printInvoice();
            invoice.ShowDialog();
        }
    }
}
