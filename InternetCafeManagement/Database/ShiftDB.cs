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
    public class ShiftDB
    {
        DBConnection connection = new DBConnection();
        public bool InsertShift(int shiftID, DateTime startTime, DateTime endTime, string weekDate, string shiftType)
        {

            SqlCommand command = new SqlCommand("EXEC pr_InsertShift", connection.getConnection);
            command.Parameters.Add("@shiftID", SqlDbType.Int).Value = shiftID;
            command.Parameters.Add("@startTime", SqlDbType.DateTime).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.DateTime).Value = endTime;
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            command.Parameters.Add("@shiftType", SqlDbType.NVarChar).Value = shiftType;

            command.CommandType = CommandType.StoredProcedure;
            
            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
                
            }
        }
    }
}
