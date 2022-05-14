using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeManagement.Database
{
    public class UserUsingComputerDB
    {
        DBConnection connection = new DBConnection();
        public bool InsertUsage(int computerID, int user_id, DateTime starting_time)
        {
            SqlCommand command = new SqlCommand("INSERT INTO user_using_computer (computerID, user_id, starting_time)"
                + " VALUES (@computerID, @user_id, @starting_time)", connection.getConnection);

            command.Parameters.Add("@computerID", SqlDbType.Int).Value = computerID;
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
            command.Parameters.Add("@starting_time", SqlDbType.DateTime).Value = starting_time;
            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() >= 1))
                {
                    connection.closeConnection();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
