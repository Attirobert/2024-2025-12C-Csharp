using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IktatoMySql
{
    class BeosztasokClass
    {
        public MySqlConnection connection;

        public BeosztasokClass(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public void dataInsert(DataRow row, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand("BeosztasInsert", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@param1", MySqlDbType.VarChar, 20).Value = row["Beosztas"];

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void dataUpdate(DataRow row, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand("BeosztasUpdate", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Beosztas", MySqlDbType.VarChar, 20).Value = row["Beosztas"];
                cmd.Parameters.Add("@PrimaryKey", MySqlDbType.Int32, 11).Value = row["Id_Beosztas", DataRowVersion.Original];

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void dataDelete(DataRow row, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand("BeosztasDelete", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PrimaryKey", MySqlDbType.Int32, 11).Value = row["Id_Beosztas", DataRowVersion.Original];

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
