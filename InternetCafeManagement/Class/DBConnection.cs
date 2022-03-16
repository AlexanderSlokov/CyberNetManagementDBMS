using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace InternetCafeManagement.Class
{
    class DBConnection
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["InternetCafeManagement.Properties.Settings.InternetCafeConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);

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
    }
}
