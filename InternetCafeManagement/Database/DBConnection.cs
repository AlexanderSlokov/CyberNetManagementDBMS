using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace InternetCafeManagement.Database
{
    class DBConnection
    {
        private const string connectionString = "Data Source=MAYTINH-0ANFSS5;Initial Catalog=InternetCafeDB;Integrated Security=True";

        // Create a new SqlConnectionStringBuilder and
        // initialize it with a few name/value pairs.
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(GetConnectionString());

        // Phần data source này các bạn MySQL server lấy tên của server  máy local để vào dưới, mỗi máy khác nhau
        SqlConnection con = new SqlConnection(@"Data Source=MAYTINH-0ANFSS5;Initial Catalog=InternetCafeDB;Integrated Security=True");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
        private static string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return connectionString;
        }
    }
}
