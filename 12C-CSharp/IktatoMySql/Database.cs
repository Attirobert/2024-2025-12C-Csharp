using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GetDBConnection;

namespace IktatoMySql
{
    class Database
    {
        public MySqlConnection mySqlConnection = new MySqlConnection(DBConnectionsClass.GetConnectionString_2("MyDBConnection"));
    }
}
