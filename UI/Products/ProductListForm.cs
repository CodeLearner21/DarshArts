using DarshArts.BLL;
using DarshArts.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarshArts.UI.Products
{
    public partial class ProductListForm : Form
    {
        private readonly ProductBUS _productBUS;
        public ProductListForm()
        {
            _productBUS = new ProductBUS();
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var products = GetProductList();
            dgvAllProductList.DataSource = products.Select(p => new { Code = p.Code, Name = p.Name, Price = p.UnitPrice }).ToList();
        }

        public IEnumerable<Product> GetProductList(string searchParam = null)
        {
            var products = _productBUS.GetAll();

            if (!string.IsNullOrWhiteSpace(searchParam))
                products = products.Where(p => p.Name.Contains(searchParam) || p.Code.Contains(searchParam)).ToList();

            return products;
        }

        private void TxtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            var products = GetProductList(txtSearchProduct.Text);
            dgvAllProductList.DataSource = products.Select(p => new { Code = p.Code, Name = p.Name, Price = p.UnitPrice }).ToList();
        }
    }
}
