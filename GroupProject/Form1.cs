using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GroupProject
{
    public partial class Form1 : Form
    {
        private XmlReader ordersStreamReader;
        private List<Product> _productsList;
        private Cart _cart;

        public Form1()
        {
            InitializeComponent();
            var qColumn = this.ProductsGrid.Columns.Add("Quantity", "Quantity ordered");
            this.ProductsGrid.Columns[qColumn].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ProductsGrid.Hide();
            this.ProductsGrid.AutoSize = true;
            this.ProductsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductsGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductsGrid.Dock = DockStyle.Fill;
            ProductsGrid.BackgroundColor = this.BackColor;
            ProductsGrid.BorderStyle = BorderStyle.None;
            _cart = new Cart();
            this.purchasebtn.Visible = false;
        }

        private void InitProductGridQuantity()
        {
            for (int i = 0; i != this.ProductsGrid.RowCount; i++)
            {
                ProductsGrid.Rows[i].Cells["Quantity"].Value = 0;
            }
        }

        private void loadProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productsFileStream = FileUtils.OpenXmlFileWithDialog("Open product listing");
            if (productsFileStream != null)
            {
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof (ProductList));
                var list = (ProductList) reader.Deserialize(productsFileStream);
                this._productsList = list.Products;
                ProductsGrid.DataSource = _productsList;
                ProductsGrid.Columns[1].DefaultCellStyle.Format = "c";
                this.labelInstructions.Hide();
                this.ProductsGrid.Show();
                InitProductGridQuantity();
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
        }

        private void loadOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordersFileStream = FileUtils.OpenXmlFileWithDialog("Open orders files");
            if (ordersFileStream != null)
                this.ordersStreamReader = ordersFileStream;
        }

        private void ProductGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductsGrid.Rows[e.RowIndex].Cells["Quantity"].Value = 0;
            if (!(e.RowIndex >= 0 && e.ColumnIndex > 0))
                return;
            var product = this._productsList[e.RowIndex];
            var popup = new AddPopup();
            if (this.ProductsGrid.Rows[e.RowIndex].Cells[2].Value != null)
                popup.ProductQuantity = (int) this.ProductsGrid.Rows[e.RowIndex].Cells[2].Value;
            popup.SetProductName(product.Name);
            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                ProductsGrid.Rows[e.RowIndex].Cells["Quantity"].Value = popup.ProductQuantity;
                _cart.update(product, popup.ProductQuantity);
                this.purchasebtn.Visible = true;
            }
            popup.Dispose();
            //_cart.displayCart();
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            var popup = new OrderForm(_cart.getTotal());
            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                Console.WriteLine("{0} {1}", popup.AccountNumber, _cart.getTotal());
                // save in xml
            }
            popup.Dispose();
        }
    }
}