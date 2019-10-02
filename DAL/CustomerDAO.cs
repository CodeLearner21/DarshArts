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
    public class CustomerDAO
    {
        private readonly SQLDatabase _sqlDatabase;
        public CustomerDAO()
        {
            _sqlDatabase = new SQLDatabase();
        }

        public DataTable GetAll()
        {
            var query = @"SELECT * FROM Customers";
            return _sqlDatabase.executeSelectQuery(query, null);
        }

        public bool Create(string code, string name, string mobile, string telephone, string address1, string address2, string city, string state, string country)
        {
            var query = @"INSERT INTO Customers (Code, Name, Mobile, Telephone, AddressLine1, AddressLine2, City, State, Country) 
                VALUES (@code, @name, @mobile, @telephone, @address1, @address2, @city, @state, @country)";

            SqlParameter[] sqlParameters = new SqlParameter[9];

            sqlParameters[0] = new SqlParameter("@code", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(code);
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(name);
            sqlParameters[2] = new SqlParameter("@mobile", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(mobile);
            sqlParameters[3] = new SqlParameter("@telephone", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(telephone);
            sqlParameters[4] = new SqlParameter("@address1", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(address1);
            sqlParameters[5] = new SqlParameter("@address2", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(address2);
            sqlParameters[6] = new SqlParameter("@city", SqlDbType.VarChar);
            sqlParameters[6].Value = Convert.ToString(city);
            sqlParameters[7] = new SqlParameter("@state", SqlDbType.VarChar);
            sqlParameters[7].Value = Convert.ToString(state);
            sqlParameters[8] = new SqlParameter("@country", SqlDbType.VarChar);
            sqlParameters[8].Value = Convert.ToString(country);

            var result = _sqlDatabase.executeInsertQuery(query, sqlParameters);

            return result;
        }

        public DataTable GetByCode(string code)
        {
            var query = "SELECT * FROM Customers.Code WHERE Code = @code";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@code", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(code);

            return _sqlDatabase.executeSelectQuery(query, sqlParameters);
        }
    }
}
