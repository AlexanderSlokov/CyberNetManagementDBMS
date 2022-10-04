using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberGamingManagement.Database
{
    public class SalaryDB
    {
        DBConnection connection = new DBConnection();
        public bool IsEmployeeCheckIn(int employee_id, TimeSpan check_in)
        {
            SqlCommand command = new SqlCommand("pr_IsEmployeeCheckIn", connection.getConnection);

            if (employee_id == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;
            command.Parameters.Add("@check_in", SqlDbType.Time).Value = check_in;
            command.CommandType = CommandType.StoredProcedure;
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
        public bool MakeCheckInForEmployee(int employee_id, int roomID,
           TimeSpan startTime, TimeSpan endTime, string weekDate, DateTime check_in_date_time)
        {
            SqlCommand command = new SqlCommand("pr_CheckIn", connection.getConnection);
            if (employee_id == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;

            if (roomID == 0)
            {
                MessageBox.Show("Please Enter Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
            if (weekDate == String.Empty)
            {
                MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
            command.Parameters.Add("@check_in", SqlDbType.DateTime).Value = check_in_date_time;

            command.CommandType = CommandType.StoredProcedure;
            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Check IN Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    return true;

                }
                else
                {
                    connection.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
