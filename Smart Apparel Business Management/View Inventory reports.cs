using Diagnostic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {

          
            try
            {
                if (gvir.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found");
                    return;
                }

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                              + "\\InventoryReport.pdf";

                Document doc = new Document(PageSize.A4);

                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Inventory Report");
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;

                doc.Add(title);

                PdfPTable table = new PdfPTable(gvir.Columns.Count);

                // Add Column Headers
                for (int i = 0; i < gvir.Columns.Count; i++)
                {
                    table.AddCell(gvir.Columns[i].HeaderText);
                }

                // Add Row Data
                for (int i = 0; i < gvir.Rows.Count; i++)
                {
                    for (int j = 0; j < gvir.Columns.Count; j++)
                    {
                        if (gvir.Rows[i].Cells[j].Value != null)
                        {
                            table.AddCell(gvir.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            table.AddCell("");
                        }
                    }
                }

                doc.Add(table);

                doc.Close();

                MessageBox.Show("PDF Generated Successfully\nSaved On Desktop");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

    }
    }
}
