using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDBConnection
{
    public class DBConnectionsClass
    {
        public static string GetConnectionString_2(string connectionName)
        {
            try
            {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

            return connectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
                return null;
            }
        }

        public static string GetConnectionString_1()
        {
            SqlConnectionStringBuilder cnstrBuilder = new SqlConnectionStringBuilder();
            cnstrBuilder.DataSource = ConfigurationManager.AppSettings["server"];
            cnstrBuilder.InitialCatalog = ConfigurationManager.AppSettings["Database"];
            cnstrBuilder.UserID = ConfigurationManager.AppSettings["user"];
            cnstrBuilder.Password = ConfigurationManager.AppSettings["password"];

            cnstrBuilder.IntegratedSecurity = true;
            cnstrBuilder.ConnectTimeout = 30;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnstrBuilder.ConnectionString;

            return cn.ConnectionString;
        }
    }
}
