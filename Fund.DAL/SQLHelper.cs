using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fund.DAL
{
    public class SQLHelper
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["mysqlConn"].ToString();
        /// <summary> 
        /// execute command，return DataTable 
        /// </summary> 
        /// <param name="SQLString">sql query command</param> 
        /// <returns>DataTable</returns> 
        public static DataTable ExecuteDataTable(string SQLString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    MySqlDataAdapter command = new MySqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds.Tables[0];
            }
        }
    }
}
