using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Utility
{
    public class SqlConnectionStringBuilderUtil
    {
        private const string connectionString = "Server=MAYTINH-0ANFSS5;Initial Catalog=InternetCafeDB;Integrated Security=True";
        public void MakeBuilder()

        {// Create a new SqlConnectionStringBuilder and
         // initialize it with a few name/value pairs.
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(GetConnectionString());
            // The input connection string used the
            // Server key, but the new connection string uses
            // the well-known Data Source key instead.
            Console.WriteLine(builder.ConnectionString);

            // Pass the SqlConnectionStringBuilder an existing
            // connection string, and you can retrieve and
            // modify any of the elements.
            builder.ConnectionString = connectionString;

            // Now that the connection string has been parsed,
            // you can work with individual items.
            Console.WriteLine(builder.Password);
            builder.Password = "new@1Password";
            builder.AsynchronousProcessing = true;

            // You can refer to connection keys using strings,
            // as well. When you use this technique (the default
            // Item property in Visual Basic, or the indexer in C#),
            // you can specify any synonym for the connection string key
            // name.
            builder["Server"] = ".";
            builder["Connect Timeout"] = 1000;
            builder["Trusted_Connection"] = true;
            Console.WriteLine(builder.ConnectionString);

            Console.WriteLine("Press Enter to finish.");
            Console.ReadLine();
        }
        private static string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "connectionString";
        }
    }
}
