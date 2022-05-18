using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Model;

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
        public DataTable GetDataTableSchedulesOfEmployee(string weekDate, int employee_id)
        {
            SqlCommand command = new SqlCommand("pr_SelectAllSchedulesOfEmployee", connection.getConnection);
            if (employee_id == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;
            if (weekDate == String.Empty)
            {
                MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
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
        public Schedule GetSchedulesOfEmployee(int employeeID, string weekDate, TimeSpan loginTime)
        {
            Schedule schedule = new Schedule();
            SqlCommand command = new SqlCommand("pr_SelectCurrentSchedulesOfEmployee", connection.getConnection);
            if (employeeID == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employeeID;

            if (weekDate == String.Empty)
            {
                MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            command.Parameters.Add("@loginTime", SqlDbType.Time).Value = loginTime;
            command.CommandType = CommandType.StoredProcedure;

            command.Connection = connection.getConnection;
            connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            schedule.WeekDate = weekDate;
            while (reader.Read())
            {
                schedule.RoomID = Int32.Parse(reader["Room ID"].ToString());
                schedule.StartTime = TimeSpan.Parse(reader["Check In Time"].ToString());
                schedule.EndTime = TimeSpan.Parse(reader["Check Out time"].ToString());
 
                schedule.Shift_type = reader["Shift Type"].ToString();
                try
                {
                    if (reader["Check In"] != null)
                    {
                        schedule.Check_in = DateTime.Parse(reader["Check In"].ToString());
                    }
                }

                catch
                {
                    schedule.Check_in = DateTime.MinValue;
                }

            }
            reader.Close();
            
            
            connection.closeConnection();
            return schedule;
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
        public bool DeleteAllShifts()
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteAllSchedules", connection.getConnection);

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
        public DataTable GetScheduleOfAllEmployees(string weekDate)
        {
            SqlCommand command = new SqlCommand("pr_GetShiftOfAllEmployees", connection.getConnection);
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            command.CommandType = CommandType.StoredProcedure;

            command.Connection = connection.getConnection;
            connection.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "schedule");

            dataTable = dataSet.Tables["schedule"];

            connection.closeConnection();
            return dataTable;
        }

        public bool IsEmployeeCheckIn(int employee_id, int roomID, TimeSpan startTime, TimeSpan endTime, string weekDate)
        {
            SqlCommand command = new SqlCommand("pr_IsEmployeeCheckIn", connection.getConnection);

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
            SqlCommand command = new SqlCommand("pr_MakeCheckIn", connection.getConnection);
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
