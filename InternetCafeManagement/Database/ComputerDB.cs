using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetCafeManagement.Model;

namespace InternetCafeManagement.Database
{
    public class ComputerDB
    {
        DBConnection connection = new DBConnection();
        // Nhận ID và kiểm tra máy tính có tồn tại với Id đó hay không, nếu có trả về true, nếu không trả về false
        public bool IsComputerExistsByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM computer WHERE id = @id", connection.getConnection);
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

        // Hàm thêm thông tin máy tính vào DB, trả về true nếu thêm thành công, false nếu thêm không thành công
        public bool AddNewComputer(int roomID, string info, string status, float fee)
        {
            SqlCommand command = new SqlCommand("INSERT INTO computer (id, info, roomID, status, fee_per_hour)"
                + " VALUES ((SELECT MAX(id) FROM computer) + 1, @info, @roomID, @status, @fee_per_hour)", connection.getConnection);

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
            catch
            {
                int id = 1;
                command = new SqlCommand("INSERT INTO computer (id, info, roomID, status, fee_per_hour)"
                + " VALUES (@id, @info, @roomID, @status, @fee_per_hour)", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@info", SqlDbType.VarChar).Value = info;
                command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                command.Parameters.Add("@fee_per_hour", SqlDbType.VarChar).Value = fee;
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
        // Hàm trả về số máy tính của một phòng
        public int ComputerCountByID(int roomID)
        {
            SqlCommand command = new SqlCommand("SELECT count(*) FROM computer as c INNER JOIN computer_room as cr " +
                "ON c.roomID = cr.id WHERE c.roomID = @id", connection.getConnection);
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
                SqlCommand command = new SqlCommand("SELECT * FROM computer WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
                SqlCommand command = new SqlCommand("SELECT * FROM computer WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
                SqlCommand command = new SqlCommand("SELECT * FROM computer WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
                SqlCommand command = new SqlCommand("SELECT * FROM computer WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
                SqlCommand command = new SqlCommand("SELECT c.id, c.info, c.roomID, c.Status, c.fee_per_hour FROM computer as c INNER JOIN computer_room as cr " +
                    "ON c.roomID = cr.id WHERE c.roomID = @roomID", connection.getConnection);
                command.Parameters.Add("@roomID", SqlDbType.Int).Value = roomID;

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
                SqlCommand command = new SqlCommand("UPDATE computer SET info = @info WHERE id = @id", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@info", SqlDbType.VarChar).Value = info;

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
                SqlCommand command = new SqlCommand("UPDATE computer SET fee_per_hour = @fee WHERE id = @id", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@fee", SqlDbType.Real).Value = fee;

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
                SqlCommand command = new SqlCommand("DELETE FROM computer WHERE id = @id", connection.getConnection);

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
        public DataTable GetDataTableAllComputer(int roomID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM computer as c INNER JOIN computer_room as cr " +
                    "ON c.roomID = cr.id WHERE c.roomID = @roomID", connection.getConnection);
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
    }
}
