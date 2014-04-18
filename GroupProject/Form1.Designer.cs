namespace GroupProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1054, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProductsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(120, 36);
            this.toolStripDropDownButton1.Text = "Products";
            // 
            // loadProductsToolStripMenuItem
            // 
            this.loadProductsToolStripMenuItem.Name = "loadProductsToolStripMenuItem";
            this.loadProductsToolStripMenuItem.Size = new System.Drawing.Size(241, 36);
            this.loadProductsToolStripMenuItem.Text = "Load products";
            this.loadProductsToolStripMenuItem.Click += new System.EventHandler(this.loadProductsToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadOrdersToolStripMenuItem,
            this.saveOrdersToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(99, 36);
            this.toolStripDropDownButton2.Text = "Orders";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // loadOrdersToolStripMenuItem
            // 
            this.loadOrdersToolStripMenuItem.Name = "loadOrdersToolStripMenuItem";
            this.loadOrdersToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.loadOrdersToolStripMenuItem.Text = "Load orders";
            this.loadOrdersToolStripMenuItem.Click += new System.EventHandler(this.loadOrdersToolStripMenuItem_Click);
            // 
            // saveOrdersToolStripMenuItem
            // 
            this.saveOrdersToolStripMenuItem.Name = "saveOrdersToolStripMenuItem";
            this.saveOrdersToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.saveOrdersToolStripMenuItem.Text = "Save orders";
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AutoGenerateColumns = false;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.ProductsGrid.DataSource = this.productBindingSource;
            this.ProductsGrid.Location = new System.Drawing.Point(29, 97);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowTemplate.Height = 33;
            this.ProductsGrid.Size = new System.Drawing.Size(296, 594);
            this.ProductsGrid.TabIndex = 2;
            this.ProductsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGrid_CellContentClick);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(331, 419);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(283, 37);
            this.labelInstructions.TabIndex = 3;
            this.labelInstructions.Text = "Load products first";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(GroupProject.Product);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 887);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "RTK Order";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loadProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem loadOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOrdersToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label labelInstructions;
    }
}

