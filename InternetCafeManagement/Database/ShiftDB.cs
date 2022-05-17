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
        public bool InsertShift(int employee_id, int roomID, TimeSpan startTime, TimeSpan endTime, string weekDate, string shiftType)
        {

            SqlCommand command = new SqlCommand("pr_InsertSchedule", connection.getConnection);
            if(employee_id == 0)
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
            
            command.Parameters.Add("@shift_type", SqlDbType.NVarChar).Value = shiftType;
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
        public bool isShiftExists(int employeeID, int roomID, TimeSpan startTime, TimeSpan endTime, string weekDate)
        {
            SqlCommand command = new SqlCommand("pr_isScheduleExsists", connection.getConnection);

            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employeeID;
            command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
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
        public bool UpdateShift(int employee_id, int roomID, TimeSpan startTime, TimeSpan endTime, string weekDate, string shiftType)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_UpdateSchedule", connection.getConnection);

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

                command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
                command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
                if (weekDate == String.Empty)
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

                command.Parameters.Add("@shift_type", SqlDbType.NVarChar).Value = shiftType;

                command.CommandType = CommandType.StoredProcedure;
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

        public DataTable GetDataTableAllSchedules()
        {
            SqlCommand command = new SqlCommand("pr_SelectAllSchedules", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Connection = connection.getConnection;
            connection.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "std");

            dataTable = dataSet.Tables["std"];

            connection.closeConnection();
            return dataTable;
        }

        public bool DeleteShift(int employeeID, int roomID, TimeSpan startTime, TimeSpan endTime, string weekDate)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteSchedule", connection.getConnection);

                command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employeeID;
                command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
                command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
                command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
                command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
                command.CommandType = CommandType.StoredProcedure;
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
