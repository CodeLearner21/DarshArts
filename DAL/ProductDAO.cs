using DarshArts.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.DAL
{
    public class ProductDAO
    {
        private readonly SQLDatabase _sqlDatabase;
        public ProductDAO()
        {
            _sqlDatabase = new SQLDatabase();
        }

        public bool AddProduct(string code, string name, decimal unitPrice)
        {
            var query = string.Format("INSERT INTO Products (Code, Name, UnitPrice) VALUES (@code, @name, @unitPrice)");

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@code", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(code);
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(name);
            sqlParameters[2] = new SqlParameter("@unitPrice", SqlDbType.Decimal);
            sqlParameters[2].Value = Convert.ToDecimal(unitPrice);

            var result = _sqlDatabase.executeInsertQuery(query, sqlParameters);
            if (result)
                return result;

            return false;
        }

        public DataTable GetByCodeOrName(string code, string name)
        {
            var query = string.Format("SELECT * FROM Products WHERE Code = @code OR Name = @name");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@code", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(code);
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(name);

            var result = _sqlDatabase.executeSelectQuery(query, sqlParameters);

            return result;
        }

        public DataTable GetAllProducts()
        {
            var queryString = @"SELECT * FROM Products";
            var query = string.Format(queryString);
            var result = _sqlDatabase.executeSelectQuery(query, null);

            return result;
        }

        public DataTable GetAllProductsWithQuantity()
        {
            var queryString = @"SELECT Products.Id, Products.Code, Products.Name, Products.UnitPrice, Stocks.Quantity
            FROM Products
            LEFT JOIN Stocks ON Products.Id = Stocks.ProductId";
            var query = string.Format(queryString);
            var result = _sqlDatabase.executeSelectQuery(query, null);

            return result;
        }
    }
}
