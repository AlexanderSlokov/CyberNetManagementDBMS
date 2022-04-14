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
        // Phần data source này các bạn MySQL server lấy tên của server  máy local để vào dưới, mỗi máy khác nhau
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OB2KPUE;Initial Catalog=internetcafedb;Integrated Security=True;
        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; MultipleActiveResultSets = True;");

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
