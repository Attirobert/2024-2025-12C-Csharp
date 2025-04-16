using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetDBConnection;
using MySql.Data.MySqlClient;

namespace DBConnectPelda2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. módszer
            //string connectionString = DBConnectionsClass.GetConnectionString_1();

            // 2. módszer
            string connectionString = DBConnectionsClass.GetConnectionString_2("MyDbConnection");

            if (!string.IsNullOrEmpty(connectionString))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Sikeres kapcsolódás!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hiba: {ex.Message}");
                    }
                }
            }
            else Console.WriteLine("Nincs kapcsolati karakterlánc a config fájlban!");

            Console.ReadKey();
        }
    }
}
