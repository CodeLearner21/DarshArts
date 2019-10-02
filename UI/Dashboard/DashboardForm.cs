using DarshArts.UI.Customers;
using DarshArts.UI.Products;
using DarshArts.UI.Stocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarshArts.UI.Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMainContainer.Controls.Clear();
            ProductListForm productListForm = new ProductListForm();
            productListForm.TopLevel = false;
            panelMainContainer.Controls.Add(productListForm);
            productListForm.Show();
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMainContainer.Controls.Clear();
            CreateProductForm productForm = new CreateProductForm();
            productForm.TopLevel = false;
            panelMainContainer.Controls.Add(productForm);
            productForm.Show();
        }

        private void ViewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMainContainer.Controls.Clear();
            StockListForm stockListForm = new StockListForm();
            stockListForm.TopLevel = false;
            panelMainContainer.Controls.Add(stockListForm);
            stockListForm.Show();
        }

        private void AddStckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMainContainer.Controls.Clear();
            CreateStockForm createStockForm = new CreateStockForm();
            createStockForm.TopLevel = false;
            panelMainContainer.Controls.Add(createStockForm);
            createStockForm.Show();
        }

        private void ManageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMainContainer.Controls.Clear();
            ManageCustomerForm manageCustomerForm = new ManageCustomerForm();
            manageCustomerForm.TopLevel = false;
            panelMainContainer.Controls.Add(manageCustomerForm);
            manageCustomerForm.Show();
        }
    }
}
