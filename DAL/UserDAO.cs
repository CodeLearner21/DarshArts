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
    public class UserDAO
    {
        private readonly SQLDatabase _sqlDatabase;
        public UserDAO()
        {
            _sqlDatabase = new SQLDatabase();
        }

        public DataTable GetUserByUsernamePassword(string username, string password)
        {
            var query = string.Format("SELECT * FROM Users WHERE Username = @username AND Password = @password");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(password);

            var result = _sqlDatabase.executeSelectQuery(query, sqlParameters);
            if (result != null && result.Rows.Count > 0)
                return result;

            return null;
        }
    }
}
