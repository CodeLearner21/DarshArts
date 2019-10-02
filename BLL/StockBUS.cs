using DarshArts.DAL;
using DarshArts.Models.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.BLL
{    
    public class StockBUS
    {

        private readonly StockDAO _stockDAO;

        public StockBUS()
        {
            _stockDAO = new StockDAO();
        }


        public IEnumerable<StockDetail> GetAll()
        {
            var result = _stockDAO.GetAllStocks();
            if (result.Rows.Count > 0)
                return result.AsEnumerable().Select(row => new StockDetail
                {
                    Id = row.Field<int>(0),
                    ProductId = row.Field<int>(1),
                    Quantity = row.Field<int>(2),
                    LastUpdated = row.Field<DateTime>(3)
                }).ToList();

            return null;
        }

        public bool AddStock(CreateStock stock)
        {
            if (stock == null)
                return false;

            return _stockDAO.AddStock(stock.ProductId, stock.Quantity, stock.LastUpdated);
        }

        public bool CheckExistingStock(int productId)
        {
            var stock = GetAll().SingleOrDefault(s => s.ProductId == productId);
            if (stock != null)
                return true;

            return false;
        }

        public bool UpdateStock(int productId, int quantity)
        {
            return _stockDAO.UpdateStockByProductId(productId, quantity);
        }

        public IEnumerable<StockListDto> GetAllStockProducts()
        {
            var result = _stockDAO.GetAllProductStocks();
            if (result == null)
                return null;

            return result.AsEnumerable().Select(row => new StockListDto
            {
                Id = row.Field<int>(0),
                ProductId = row.Field<int>(1),
                Quantity = row.Field<int>(2),
                LastUpdated = row.Field<DateTime>(3),
                ProductCode = row.Field<string>(4),
                ProductName = row.Field<string>(5),
                ProductUnitPrice = row.Field<decimal>(6)
            }).ToList();
        }
    }
}
