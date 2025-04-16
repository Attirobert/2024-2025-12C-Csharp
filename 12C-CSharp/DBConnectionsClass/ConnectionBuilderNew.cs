// Program.cs (egyszeru konzolos pelda modern .NET Core-hoz)
using System;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
//using System.Configuration;

namespace ConnectionBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konfiguracio beolvasasa appsettings.json-bol
            var config = new ConfigurationBuilder()
                //.SetBasePath(AppContext.BaseDirectory)
                //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connStr = BuildConnectionString(config);
            Console.WriteLine("Kapcsolati karakterlánc:");
            Console.WriteLine(connStr);
        }

        static string BuildConnectionString(IConfiguration config)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = config["Database:Server"],
                InitialCatalog = config["Database:Name"],
                ConnectTimeout = 30,
                ApplicationName = "ConnectionBuilderExample"
            };

            if (bool.TryParse(config["Database:UseWindowsAuth"], out bool useWindowsAuth) && useWindowsAuth)
            {
                builder.IntegratedSecurity = true;
            }
            else
            {
                builder.IntegratedSecurity = false;
                builder.UserID = config["Database:User"] ?? throw new Exception("User is required");
                builder.Password = config["Database:Password"] ?? throw new Exception("Password is required");
            }

            return builder.ConnectionString;
        }
    }
}

