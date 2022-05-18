using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Model;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.Database
{
    public class ComputerDB
    {
        DBConnection connection = new DBConnection();
        // Nhận ID và kiểm tra máy tính có tồn tại với Id đó hay không, nếu có trả về true, nếu không trả về false
        public bool IsComputerExistsByID(int id)
        {
            SqlCommand command = new SqlCommand("pr_IsComputerExistsByID", connection.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool isComputerExistsByMacAddress(string macAddress)
        {
            SqlCommand command = new SqlCommand("pr_isComputerExistsByMacAddress", connection.getConnection);
            command.Parameters.Add("@macAddress", SqlDbType.NVarChar).Value = macAddress;
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
        // Hàm thêm thông tin máy tính vào DB, trả về true nếu thêm thành công, false nếu thêm không thành công

        public bool AddNewComputer(int roomID, string info, string status, float fee)
        {
            SqlCommand command = new SqlCommand("pr_AddNewComputer", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@info", SqlDbType.VarChar).Value = info;
            command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@fee_per_hour", SqlDbType.Real).Value = fee;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool AddNewComputer(int roomID, string info, string status, float fee, string macAddress)
        {
            SqlCommand command = new SqlCommand("pr_AddNewComputerWithMac", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@info", SqlDbType.VarChar).Value = info;
            command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@fee_per_hour", SqlDbType.Real).Value = fee;
            command.Parameters.Add("@macAddress", SqlDbType.NChar).Value = macAddress;
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
        // Hàm trả về số máy tính của một phòng
        public int ComputerCountByID(int roomID)
        {
            SqlCommand command = new SqlCommand("pr_ComputerCountByID", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            connection.openConnection();
            command.Parameters.Add("@id", SqlDbType.Int).Value = roomID;
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.closeConnection();
            return count;
        }
        // Hàm trả về info của máy tính theo ID
        public string GetComputerInfo(int id)
        {
            string info = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("pr_GetComputerInfo", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    info = reader["info"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return info;
            }
            catch
            {
                return info;
            }
        }
        // Hàm trả về info của id của phòng máy tính được đặt, tìm kiếm theo ID
        public int GetComputerRoomID(int id)
        {
            int roomID = 0;
            try
            {
                SqlCommand command = new SqlCommand("pr_GetComputerRoomID", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    roomID = Int32.Parse(reader["roomID"].ToString());
                }
                reader.Close();
                connection.closeConnection();
                return roomID;
            }
            catch
            {
                return roomID;
            }
        }
        // Hàm trả về trạng thái của máy tính theo ID
        public string GetComputerStatus(int id)
        {
            string status = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("pr_GetComputerStatus", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    status = reader["status"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return status;
            }
            catch
            {
                return status;
            }
        }
        // Hàm trả về số tiền thuê trong một giờ của máy tính theo ID
        public float GetComputerFeePerHour(int id)
        {
            float fee = 0;
            try
            {
                SqlCommand command = new SqlCommand("pr_GetComputerFeePerHour", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fee = float.Parse(reader["fee_per_hour"].ToString());
                }
                reader.Close();
                connection.closeConnection();
                return fee;
            }
            catch
            {
                return fee;
            }
        }
        // Hàm trả về một danh sách các máy tính của một phòng
        public List<Computer> GetAllComputersByRoomID(int roomID)
        {
            List<Computer> computersList = new List<Computer>();
            try
            {
                SqlCommand command = new SqlCommand("pr_GetDataTableAllComputerByRoomID", connection.getConnection);
                command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                int count = reader.FieldCount;
                while (reader.Read())
                {
                    Computer computer = new Computer();
                    computer.Id = Int32.Parse(reader["id"].ToString());
                    computer.Info = reader["info"].ToString();
                    computer.RoomID = Int32.Parse(reader["roomID"].ToString());
                    computer.Status = reader["status"].ToString();
                    computer.Fee_per_hour = float.Parse(reader["fee_per_hour"].ToString());
                    computersList.Add(computer);
                }
                reader.Close();
                connection.closeConnection();
                return computersList;
            }
            catch
            {
                return computersList;
            }
        }
        // hàm cập nhật thông  tin máy, trả về true nếu cập nhật thành công, trả về false nếu cập nhật ko thành công
        public bool UpdateInfo(int id, string info)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_UpdateInfo", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@info", SqlDbType.VarChar).Value = info;
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
        // hàm cập nhật tiền thuê máy, trả về true nếu cập nhật thành công, trả về false nếu cập nhật ko thành công
        public bool UpdateFeePerHour(int id, float fee)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_UpdateFeePerHour", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@fee", SqlDbType.Real).Value = fee;
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
        public bool MakeBusy(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_MakeBusy", connection.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = Status.busy;

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
        public bool MakeAvailable(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_MakeAvailable", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = Status.available;
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
        public bool MakeInUse(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_MakeInUse", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = Status.in_use;
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
        // hàm xoá máy tính khỏi db, trả về true nếu cập nhật thành công, trả về false nếu cập nhật ko thành công
        public bool DeleteComputer(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteComputer", connection.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
        public DataTable GetDataTableAllComputerByRoomID(int roomID)
        {
            SqlCommand command = new SqlCommand("pr_GetDataTableAllComputerByRoomID", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
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
        public Computer GetComputerByMacAddress(string macAddress)
        {
            Computer computer = new Computer();
            try
            {
                SqlCommand command = new SqlCommand("pr_GetComputerByMacAddress", connection.getConnection);
                command.Parameters.Add("@macAdress", SqlDbType.NVarChar).Value = macAddress;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    computer.Id = Int32.Parse(reader["id"].ToString());
                    computer.Info = reader["info"].ToString();
                    computer.RoomID = Int32.Parse(reader["roomID"].ToString());
                    computer.Status = reader["status"].ToString();
                    computer.Fee_per_hour = float.Parse(reader["fee_per_hour"].ToString());
                    computer.MacAddress = reader["macAddress"].ToString();

                }
                reader.Close();
                if( computer.Id != 0)
                {
                    connection.closeConnection();
                    return computer;
                }
                else
                {
                    connection.closeConnection();
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
