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

        public Form1()
        {
            InitializeComponent();
            this.ProductsGrid.Hide();
            this.ProductsGrid.AutoSize = true;
            this.ProductsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            ProductsGrid.Dock = DockStyle.Fill;
            ProductsGrid.BackgroundColor = this.BackColor;
            ProductsGrid.BorderStyle = BorderStyle.None;

//            this.ProductsGrid.DataBindingComplete += (sender, args) => this.ProductsGrid.Show();
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
            var k = this._productsList[e.RowIndex];
        }
    }
}