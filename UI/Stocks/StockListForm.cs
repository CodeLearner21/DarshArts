using DarshArts.BLL;
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
    public partial class StockListForm : Form
    {
        private readonly StockBUS _stockBUS;
        public StockListForm()
        {
            _stockBUS = new StockBUS();
            InitializeComponent();
        }

        private void StockListForm_Load(object sender, EventArgs e)
        {
            lblStockListLoader.Visible = true;
            
        }

        private void LoadStocks()
        {
            var stockList = _stockBUS.GetAll();            
        }
    }
}
