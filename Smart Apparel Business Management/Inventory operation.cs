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
    public partial class Inventory_operation : Form
    {
        public Inventory_Manager im;
        public Inventory_operation(Inventory_Manager pre)
        {
            this.im = pre;
            InitializeComponent();
            LoadData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblbnd_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            im.Visible = true;

        }

        private void btnap_Click(object sender, EventArgs e)
        {

            try
            {
                DataAccess da = new DataAccess();

                string category = "";

                // Radio Button Category
                if (rbt.Checked)
                {
                    category = "T-Shirt";
                }
                else if (rbfs.Checked)
                {
                    category = "Formal Shirt";
                }
                else if (rbfp.Checked)
                {
                    category = "Formal Pant";
                }
                else if (rbcp.Checked)
                {
                    category = "Casual Pant";
                }

                string brand = "";

                // Checkbox Brand
                if (cbdn.Checked)
                {
                    brand = "Denim";
                }
                else if (cbnk.Checked)
                {
                    brand = "Nike";
                }
                else if (cbads.Checked)
                {
                    brand = "Adidas";
                }

                string productName = txtpname.Text;
                string size = cmbsize.Text;
                string color = comboBox1.Text;

                int quantity = Convert.ToInt32(txtqnt.Text);

                string query = "INSERT INTO ProductInventory " +
                               "(supplierId, productName, category, brand, size, color, totalStock, availableStock, purchasePrice, sellingPrice) " +
                               "VALUES " +
                               "(1, '" + productName + "', '" + category + "', '" + brand + "', '" + size + "', '" + color + "', " + quantity + ", " + quantity + ", 100, 150)";

                int count = da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Product Added Successfully");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to Add Product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void LoadData()
        {
            try
            {
                DataAccess da = new DataAccess();

                string sql = "SELECT * FROM ProductInventory";

                DataTable dt = da.ExecuteQueryTable(sql);

                gvio.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Inventory_operation_Load(object sender, EventArgs e)
        {

        }
        private void gvio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gvio.Rows[e.RowIndex];

                    txtpid.Text = row.Cells["productId"].Value.ToString();
                    txtpname.Text = row.Cells["productName"].Value.ToString();

                    txtqnt.Text = row.Cells["totalStock"].Value.ToString();

                    // Category RadioButton
                    string category = row.Cells["category"].Value.ToString();

                    rbt.Checked = false;
                    rbfs.Checked = false;
                    rbfp.Checked = false;
                    rbcp.Checked = false;

                    if (category == "T-Shirt")
                    {
                        rbt.Checked = true;
                    }
                    else if (category == "Formal Shirt")
                    {
                        rbfs.Checked = true;
                    }
                    else if (category == "Formal Pant")
                    {
                        rbfp.Checked = true;
                    }
                    else if (category == "Casual Pant")
                    {
                        rbcp.Checked = true;
                    }

                    // Brand Checkbox
                    string brand = row.Cells["brand"].Value.ToString();

                    cbdn.Checked = false;
                    cbnk.Checked = false;
                    cbads.Checked = false;

                    if (brand == "Denim")
                    {
                        cbdn.Checked = true;
                    }
                    else if (brand == "Nike")
                    {
                        cbnk.Checked = true;
                    }
                    else if (brand == "Adidas")
                    {
                        cbads.Checked = true;
                    }

                    cmbsize.Text = row.Cells["size"].Value.ToString();

                    comboBox1.Text = row.Cells["color"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataAccess da = new DataAccess();

                string productId = txtpid.Text;

                string category = "";

                if (rbt.Checked)
                {
                    category = "T-Shirt";
                }
                else if (rbfs.Checked)
                {
                    category = "Formal Shirt";
                }
                else if (rbfp.Checked)
                {
                    category = "Formal Pant";
                }
                else if (rbcp.Checked)
                {
                    category = "Casual Pant";
                }

                string brand = "";

                if (cbdn.Checked)
                {
                    brand = "Denim";
                }
                else if (cbnk.Checked)
                {
                    brand = "Nike";
                }
                else if (cbads.Checked)
                {
                    brand = "Adidas";
                }

                string productName = txtpname.Text;
                string size = cmbsize.Text;
                string color = comboBox1.Text;

                int quantity = Convert.ToInt32(txtqnt.Text);

                string query = "UPDATE ProductInventory SET " +
                               "productName = '" + productName + "', " +
                               "category = '" + category + "', " +
                               "brand = '" + brand + "', " +
                               "size = '" + size + "', " +
                               "color = '" + color + "', " +
                               "totalStock = " + quantity + ", " +
                               "availableStock = " + quantity + " " +
                               "WHERE productId = " + productId;

                int count = da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Product Updated Successfully");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

    }

        private void btnrp_Click(object sender, EventArgs e) { 
      
            try
            {
                if (txtpid.Text == "")
                {
                    MessageBox.Show("Please Select a Product First");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataAccess da = new DataAccess();

                    string query = "DELETE FROM ProductInventory WHERE productId = " + txtpid.Text;

                    int count = da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Product Removed Successfully");

                        ClearFields();

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
    private void ClearFields()
        {
            txtpid.Clear();
            txtpname.Clear();
            txtqnt.Clear();

            cmbsize.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

            rbt.Checked = false;
            rbfs.Checked = false;
            rbfp.Checked = false;
            rbcp.Checked = false;

            cbdn.Checked = false;
            cbnk.Checked = false;
            cbads.Checked = false;
        }

        private void gvio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
