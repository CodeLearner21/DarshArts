﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.Database
{
    public class SQLDatabase
    {
        private SqlDataAdapter dbAdapter;
        private SqlConnection conn;
        public SQLDatabase()
        {
            dbAdapter = new SqlDataAdapter();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        /// <method>
        /// Open Database Connection if Closed or Broken
        /// </method>
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        /// <method>
        /// Select Query
        /// </method>
        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                if(sqlParameter != null)
                    sqlCommand.Parameters.AddRange(sqlParameter);
                sqlCommand.ExecuteNonQuery();
                dbAdapter.SelectCommand = sqlCommand;
                dbAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }

        /// <method>
        /// Insert Query
        /// </method>
        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand slqCommand = new SqlCommand();
            try
            {
                slqCommand.Connection = openConnection();
                slqCommand.CommandText = _query;
                slqCommand.Parameters.AddRange(sqlParameter);
                dbAdapter.InsertCommand = slqCommand;
                slqCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        /// <method>
        /// Update Query
        /// </method>
        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameter);
                dbAdapter.UpdateCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
    }
}
