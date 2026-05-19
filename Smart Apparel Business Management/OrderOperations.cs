using System;
using System.Data;
using System.Windows.Forms;

namespace Smart_Apparel_Business_Management
{
    public partial class OrderOperations : Form
    {
        public OrderOperations()
        {
            InitializeComponent();
            this.Load += OrderOperations_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnReset.Click += btnReset_Click;
            btnOback.Click += btnOback_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void OrderOperations_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadGrid();
        }

        private void LoadComboBoxes()
        {
            try
            {
                cmb1.DataSource = SalesDataStore.GetProductsList();
                cmb1.DisplayMember = "ProductName";
                cmb1.ValueMember = "ProductID";

                cmb2.Items.Clear();
                for (int i = 1; i <= 20; i++) cmb2.Items.Add(i.ToString());
                if (cmb2.Items.Count > 0) cmb2.SelectedIndex = 0;

                cmb3.DataSource = SalesDataStore.GetCustomersList();
                cmb3.DisplayMember = "Name";
                cmb3.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Combo load error:\n" + ex.Message);
            }
        }

        private void LoadGrid()
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
                MessageBox.Show("Order load error:\n" + ex.Message);
            }
        }

        private int SelectedProductID()
        {
            if (cmb1.SelectedValue == null) return 0;
            return Convert.ToInt32(cmb1.SelectedValue);
        }

        private int SelectedCustomerID()
        {
            if (cmb3.SelectedValue == null) return 0;
            return Convert.ToInt32(cmb3.SelectedValue);
        }

        private int SelectedQuantity()
        {
            int quantity;
            if (!int.TryParse(Convert.ToString(cmb2.SelectedItem), out quantity)) quantity = 1;
            return quantity;
        }

        private int SelectedOrderID()
        {
            if (dataGridView1.CurrentRow == null) return 0;
            if (dataGridView1.CurrentRow.Cells["OrderID"].Value == null) return 0;
            return Convert.ToInt32(dataGridView1.CurrentRow.Cells["OrderID"].Value);
        }

        private bool ValidateOrderInput()
        {
            if (SelectedProductID() == 0) { MessageBox.Show("Please select a product."); return false; }
            if (SelectedCustomerID() == 0) { MessageBox.Show("Please select a customer. Add customer first."); return false; }
            if (SelectedQuantity() <= 0) { MessageBox.Show("Please select a valid quantity."); return false; }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateOrderInput()) return;
            try
            {
                SalesDataStore.AddOrder(SelectedProductID(), SelectedCustomerID(), SelectedQuantity());
                MessageBox.Show("Order added successfully.");
                LoadComboBoxes(); LoadGrid();
            }
            catch (Exception ex) { MessageBox.Show("Order add error:\n" + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int orderId = SelectedOrderID();
            if (orderId == 0) { MessageBox.Show("Please select an order to update."); return; }
            if (!ValidateOrderInput()) return;
            try
            {
                SalesDataStore.UpdateOrder(orderId, SelectedProductID(), SelectedCustomerID(), SelectedQuantity());
                MessageBox.Show("Order updated successfully.");
                LoadComboBoxes(); LoadGrid();
            }
            catch (Exception ex) { MessageBox.Show("Order update error:\n" + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderId = SelectedOrderID();
            if (orderId == 0) { MessageBox.Show("Please select an order to delete."); return; }
            DialogResult result = MessageBox.Show("Do you want to delete this order?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            try
            {
                SalesDataStore.DeleteOrder(orderId);
                MessageBox.Show("Order deleted successfully.");
                LoadComboBoxes(); LoadGrid();
            }
            catch (Exception ex) { MessageBox.Show("Order delete error:\n" + ex.Message); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (cmb1.Items.Count > 0) cmb1.SelectedIndex = 0;
            if (cmb2.Items.Count > 0) cmb2.SelectedIndex = 0;
            if (cmb3.Items.Count > 0) cmb3.SelectedIndex = 0;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            object productName = dataGridView1.CurrentRow.Cells["ProductName"].Value;
            object customerName = dataGridView1.CurrentRow.Cells["CustomerName"].Value;
            object qty = dataGridView1.CurrentRow.Cells["Quantity"].Value;
            if (productName != null) cmb1.Text = productName.ToString();
            if (customerName != null) cmb3.Text = customerName.ToString();
            if (qty != null) cmb2.Text = qty.ToString();
        }

        private void btnOback_Click(object sender, EventArgs e) { this.Close(); }
        private void label2_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
