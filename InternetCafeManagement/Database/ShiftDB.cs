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
        public bool InsertShift(int shiftID, TimeSpan startTime, TimeSpan endTime, string weekDate, string shiftType)
        {

            SqlCommand command = new SqlCommand("EXEC pr_InsertShift", connection.getConnection);
            if(shiftID == 0)
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@shiftID", SqlDbType.Int).Value = shiftID;
            
            command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
            if(weekDate == String.Empty)
            {
                MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            if (shiftType == String.Empty)
            {
                MessageBox.Show("Please Enter Shift Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
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
        public bool isShiftExists(int id)
        {
            SqlCommand command = new SqlCommand("EXEC pr_isShiftExsists", connection.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }
}
