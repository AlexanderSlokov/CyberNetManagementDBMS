using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Database
{
    public class ShiftDB
    {
        public bool InsertShift(int shiftID, DateTime startTime, DateTime endTime, string weekDay, string shiftType)
        {
            

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@balance", SqlDbType.Float).Value = 0;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
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
        }
    }
}
