using DarshArts.Database;
using DarshArts.Models.Stocks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.DAL
{
    public class StockDAO
    {
        private readonly SQLDatabase _sqlDatabase;
        public StockDAO()
        {
            _sqlDatabase = new SQLDatabase();
        }

        public DataTable GetAllStocks()
        {
            var query = "SELECT * FROM Stocks";
            var result = _sqlDatabase.executeSelectQuery(query, null);

            return result;
        }

        public DataTable GetAllProductStocks()
        {
            var query = string.Format(@"SELECT Stocks.Id, Stocks.ProductId, Stocks.Quantity, Stocks.LastUpdated, Products.Code, Products.Name, Products.UnitPrice 
                FROM Stocks 
                LEFT JOIN Products 
                ON Stocks.ProductId = Products.Id");

            var result = _sqlDatabase.executeSelectQuery(query, null);
            if (result != null && result.Rows.Count > 0)
                return result;

            return null;
        }

        public bool AddStock(int productId, int quantity, DateTime lastUpdated)
        {
            var query = string.Format("INSERT INTO Stocks (ProductId, Quantity, LastUpdated) VALUES (@productId, @quantity, @lastUpdated)");

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@productId", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(productId);
            sqlParameters[1] = new SqlParameter("@quantity", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(quantity);
            sqlParameters[2] = new SqlParameter("@lastUpdated", SqlDbType.DateTime);
            sqlParameters[2].Value = Convert.ToDateTime(lastUpdated);

            var result = _sqlDatabase.executeInsertQuery(query, sqlParameters);
            if (result)
                return result;

            return false;
        }

        public DataTable GetStockById(int stockId)
        {
            var query = string.Format("SELECT * FROM Stocks WHERE Stocks.Id = @stockId");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@stockId", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(stockId);
            var result = _sqlDatabase.executeSelectQuery(query, sqlParameters);
            if (result.Rows.Count > 0)
                return result;

            return null;
        }

        public bool UpdateStock(int stockId, int quantity)
        {
            var query = string.Format("UPDATE Stocks SET Stocks.Quantity = @quantity WHERE Stocks.Id = @stockId");

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@quantity", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(quantity);
            sqlParameters[1] = new SqlParameter("@stockId", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(stockId);

            var result = _sqlDatabase.executeUpdateQuery(query, sqlParameters);
            if (result)
                return result;

            return false;
        }

        public bool UpdateStockByProductId(int productId, int quantity)
        {
            var query = string.Format("UPDATE Stocks SET Stocks.Quantity = @quantity WHERE Stocks.ProductId = @productId");

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@quantity", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(quantity);
            sqlParameters[1] = new SqlParameter("@productId", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(productId);

            var result = _sqlDatabase.executeUpdateQuery(query, sqlParameters);
            if (result)
                return result;

            return false;
        }
    }
}
