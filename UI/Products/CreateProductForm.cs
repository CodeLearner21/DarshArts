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
    public partial class CreateProductForm : Form
    {
        private readonly ProductBUS _productBUS;
        public CreateProductForm()
        {
            _productBUS = new ProductBUS();
            InitializeComponent();
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void LoadProductList()
        {
            var productList = _productBUS.GetAll();
            dgvProductList.DataSource = productList.Select(p => new { Code = p.Code, Name = p.Name, Price = p.UnitPrice }).ToList();
        }

        private void BtnResetProduct_Click(object sender, EventArgs e)
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            txtProductUnitPrice.Text = "";
        }

        private void BtnProductSave_Click(object sender, EventArgs e)
        {
            // Validate form
            var isValidCode = ValidateProudctCode();
            var isValidName = ValidateProudctName();
            var isValidPrice = ValidateProudctPrice();

            if(isValidCode && isValidName && isValidPrice)
            {
                // Parse price string to decimal
                decimal price;
                if(!decimal.TryParse(txtProductUnitPrice.Text, out price))
                {
                    ValidateProudctPrice();
                }

                // Prepare model
                var product = new CreateProduct
                {
                    Code = txtProductCode.Text,
                    Name = txtProductName.Text,
                    UnitPrice = price
                };

                if(_productBUS.AddProduct(product))
                {
                    MessageBox.Show("Data saved successfully");
                    LoadProductList();
                }
                else
                {
                    MessageBox.Show("Data not added in database! Please contact administrator.");
                }

            }
            else
            {
                MessageBox.Show("Enter valid data");
            }
        }

        private void TxtProductCode_Validating(object sender, CancelEventArgs e)
        {
            ValidateProudctCode();
        }

        private void TxtProductName_Validating(object sender, CancelEventArgs e)
        {
            ValidateProudctName();
        }

        private void TxtProductUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidateProudctPrice();
        }

        private bool ValidateProudctCode()
        {
            var flag = true;
            if (string.IsNullOrEmpty(txtProductCode.Text))
            {
                epProductCode.SetError(txtProductCode, "Product code is required.");
                flag = false;
            }
            else if(string.Format(txtProductCode.Text).Contains(" "))
            {
                epProductCode.SetError(txtProductCode, "Invalid code! spaces within code not allowed.");
                flag = false;
            }
            else
            {
                epProductCode.SetError(txtProductCode, null);
            }

            return flag;
        }

        private bool ValidateProudctName()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                epProductName.SetError(txtProductName, "Product name is required.");
                flag = false;
            }
            else
            {
                epProductName.SetError(txtProductName, null);
                flag = true;
            }
            return flag;
        }

        private bool ValidateProudctPrice()
        {
            var flag = true;
            if (string.IsNullOrEmpty(txtProductUnitPrice.Text))
            {
                epProductPrice.SetError(txtProductUnitPrice, "Product unit price is required.");
                flag = false;
            }
            else
            {
                decimal temp;
                if(!Decimal.TryParse(txtProductUnitPrice.Text, out temp))
                {
                    epProductPrice.SetError(txtProductUnitPrice, "Invalid price enter.");
                    flag = false;
                }
                else
                {
                    epProductPrice.SetError(txtProductUnitPrice, null);
                    flag = true;
                }
            }

            return flag;
        }

        
    }
}
