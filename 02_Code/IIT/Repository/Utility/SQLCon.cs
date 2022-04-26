using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public static class SQLCon
    {
        private static SqlConnection connection = null;

        public static SqlConnection Sqlconn()
        {
            try
            {
                if (connection?.State == ConnectionState.Open)
                {
                    return connection;
                }

                string str = ConfigurationManager.AppSettings["Connection"].ToString();
                connection = new SqlConnection
                {
                    ConnectionString = str
                };
                connection.Open();
            }
            catch (Exception ex) { throw ex; }
            return connection;
        }
        public static string connectionString()
        {
            return ConfigurationManager.AppSettings["Connection"].ToString();
        }
    }
}
