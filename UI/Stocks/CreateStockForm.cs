using DarshArts.BLL;
using DarshArts.Models.Products;
using DarshArts.Models.Stocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarshArts.UI.Stocks
{
    public partial class CreateStockForm : Form
    {
        private readonly ProductBUS _productBUS;
        private readonly StockBUS _stockBUS;
        public CreateStockForm()
        {
            _productBUS = new ProductBUS();
            _stockBUS = new StockBUS();
            InitializeComponent();
        }

        private void BtnSaveStock_Click(object sender, EventArgs e)
        {
            var isValidQuantity = ValidateStockQuantity();
            var isValidProduct = ValidateStockProduct();

            if(isValidProduct && isValidQuantity)
            {
                int quantity;
                int productId;
                if(!int.TryParse(txtQuantity.Text, out quantity) || !int.TryParse(cbProduct.SelectedValue.ToString(), out productId))
                {
                    MessageBox.Show("Stock not added, invalid data");
                }
                else
                {
                    if (_stockBUS.CheckExistingStock(productId))
                    {
                        // Update stock
                        _stockBUS.UpdateStock(productId, quantity);
                        MessageBox.Show("Stock updated");
                        LoadStockDataInGridview();
                    }
                    else
                    {
                        // Create stock
                        var createStock = new CreateStock
                        {
                            ProductId = productId,
                            Quantity = quantity,
                            LastUpdated = DateTime.Now
                        };
                        _stockBUS.AddStock(createStock);
                        MessageBox.Show("Stock created");
                        LoadStockDataInGridview();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid stock details");
            }
        }

        private void CreateStockForm_Load(object sender, EventArgs e)
        {

            var products = _productBUS.GetAll();
            if(products.Count() > 0)
            {                
                cbProduct.DataSource = products;
                cbProduct.SelectedIndex = -1;               
            }

            LoadStockDataInGridview();
        }

        private void TxtQuantity_Validating(object sender, CancelEventArgs e)
        {
            ValidateStockQuantity();
        }

        private void CbProduct_Validating(object sender, CancelEventArgs e)
        {
            ValidateStockProduct();
        }

        private bool ValidateStockQuantity()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                epStockQuantity.SetError(txtQuantity, "Stock quantity is required");
                flag = false;
            }
            else
            {
                int tempQuantity;
                if(!int.TryParse(txtQuantity.Text, out tempQuantity))
                {
                    epStockQuantity.SetError(txtQuantity, "Quantity must be in number only");
                    flag = false;
                }
                else
                {
                    epStockQuantity.SetError(txtQuantity, null);
                    flag = true;
                }
            }


            return flag;
        }

        private bool ValidateStockProduct()
        {
            var flag = true;

            if (cbProduct.SelectedItem == null)
            {
                epStockProduct.SetError(cbProduct, "Please select product");
                flag = false;
            }
            else
            {
                epStockProduct.SetError(cbProduct, null);
                flag = true;
             
            }


            return flag;
        }

        private void CbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedItemId = (int)cbProduct.SelectedValue;
            var selectedStock = _stockBUS.GetAllStockProducts().SingleOrDefault(st => st.ProductId == selectedItemId);
            if (selectedStock != null)
                txtQuantity.Text = selectedStock.Quantity.ToString();
            else
                txtQuantity.Text = "0";
        }

        private void LoadStockDataInGridview()
        {
            var stocks = _stockBUS.GetAllStockProducts();
            dgvStockList.DataSource = stocks;
        }
    }
}
