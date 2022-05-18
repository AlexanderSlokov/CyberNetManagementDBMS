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
        public bool InsertUsage(int computer_id, int user_id, DateTime starting_time)
        {
            SqlCommand command = new SqlCommand("pr_InsertUsage", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@computer_id", SqlDbType.Int).Value = computer_id;
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
        public bool isLogin(int computer_id, int user_id)
        {
            SqlCommand command = new SqlCommand("pr_isLogin", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@computer_id", SqlDbType.Int).Value = computer_id;
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
            connection.openConnection();
            try
            {
                if (command.ExecuteScalar() == null)
                {
                    connection.closeConnection();
                    return false;
                }
                else
                {
                    connection.closeConnection();
                    return true;
                }
            }
            catch
            {
                connection.closeConnection();
                return false;
            }
        }
        public bool DeleteUsage(int computer_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteUsage", connection.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@computer_id", SqlDbType.Int).Value = computer_id;

                connection.openConnection();
                if ((command.ExecuteNonQuery() >= 1))
                {
                    connection.closeConnection();
                    return true;
                }
                else
                {
                    connection.closeConnection();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }

}
