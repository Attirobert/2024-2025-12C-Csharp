using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GetDBConnection
{
    public class DBConnectionsClass
    {
        public static string GetConnectionString_2(string connectionName)
        {
            // string connectionName: A konfigurációs fájlban szereplő connection string neve, amelyet kulcsként használunk.
            try
            {
                // Az App.config fájlban lévő <connectionStrings> szekcióból próbálja kiolvasni a connectionName nevű kapcsolatot.
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
            /*
             * A metódus dinamikusan épít fel egy SQL Server kapcsolat karakterláncot (connection string) a konfigurációs állományból (App.config) beolvasott értékek alapján, majd visszaadja azt.
             */
            SqlConnectionStringBuilder cnstrBuilder = new SqlConnectionStringBuilder();
            cnstrBuilder.DataSource = ConfigurationManager.AppSettings["server"];
            cnstrBuilder.InitialCatalog = ConfigurationManager.AppSettings["Database"];
            cnstrBuilder.UserID = ConfigurationManager.AppSettings["user"];
            cnstrBuilder.Password = ConfigurationManager.AppSettings["password"];

            cnstrBuilder.IntegratedSecurity = true;
            /*
              Az `IntegratedSecurity = true` azt jelenti, hogy Windows-hitelesítést használ a kapcsolat – tehát nem kell felhasználónév és jelszó az adatbázishoz való kapcsolódáshoz.
>            Tehát, a `UserID` és `Password` sorok feleslegesek ebben az esetben, mert az `IntegratedSecurity = true` azokat figyelmen kívül hagyja. Az `IntegratedSecurity = false` esetben viszont szükséges
             */
            cnstrBuilder.ConnectTimeout = 30;   // 30 másodperces időkorlátot állít be a kapcsolódásra az SQL szerverhez.


            // A kapcsolat objektumot csak azért hozza létre, hogy belőle visszaadja a connection stringet.
            // A kapcsolat nem kerül megnyitásra, tehát nem történik hálózati művelet!
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnstrBuilder.ConnectionString;

            return cn.ConnectionString;
        }
    }
}
