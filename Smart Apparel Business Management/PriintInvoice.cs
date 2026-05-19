using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class printInvoice : Form
    {
        private DataRowView currentOrder;

        public printInvoice()
        {
            InitializeComponent();
            this.Load += printInvoice_Load;
            btnPrBack.Click += btnPrBack_Click;
        }

        private void printInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = SalesDataStore.GetOrdersTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invoice load error:\n" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }
            currentOrder = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (currentOrder == null)
            {
                MessageBox.Show("Please select a valid order.");
                return;
            }
            PrintDocument document = new PrintDocument();
            document.PrintPage += Document_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = document;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);
            int y = 60;
            e.Graphics.DrawString("The Trendy Tees", titleFont, Brushes.Black, 250, y); y += 50;
            e.Graphics.DrawString("Invoice", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 330, y); y += 50;
            e.Graphics.DrawString("Invoice ID: " + currentOrder["OrderID"], normalFont, Brushes.Black, 80, y); y += 30;
            e.Graphics.DrawString("Date: " + Convert.ToDateTime(currentOrder["OrderDate"]).ToString("dd-MMM-yyyy hh:mm tt"), normalFont, Brushes.Black, 80, y); y += 30;
            e.Graphics.DrawString("Customer: " + currentOrder["CustomerName"], normalFont, Brushes.Black, 80, y); y += 40;
            e.Graphics.DrawString("Product: " + currentOrder["ProductName"], normalFont, Brushes.Black, 80, y); y += 30;
            e.Graphics.DrawString("Quantity: " + currentOrder["Quantity"], normalFont, Brushes.Black, 80, y); y += 30;
            e.Graphics.DrawString("Unit Price: " + Convert.ToDecimal(currentOrder["UnitPrice"]).ToString("0.00"), normalFont, Brushes.Black, 80, y); y += 30;
            e.Graphics.DrawString("Total Amount: " + Convert.ToDecimal(currentOrder["TotalAmount"]).ToString("0.00"), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, 80, y);
        }

        private void btnPrBack_Click(object sender, EventArgs e) { this.Close(); }
    }
}
