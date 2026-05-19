using System;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class ViewDashboard : Form
    {
        public ViewDashboard()
        {
            InitializeComponent();
            this.Load += ViewDashboard_Load;
            btnBack1.Click += btnBack1_Click;
        }

        private void ViewDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                lblShowProduct.Text = SalesDataStore.CountProducts().ToString();
                lblShowCustomers.Text = SalesDataStore.CountCustomers().ToString();
                lblShowSales.Text = SalesDataStore.TotalSales().ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard load error:\n" + ex.Message);
            }
        }

        private void lblShowCustomers_Click(object sender, EventArgs e) { }
        private void btnBack1_Click(object sender, EventArgs e) { this.Close(); }
    }
}
