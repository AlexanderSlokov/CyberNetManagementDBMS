using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Database
{
    
    public class ComputerRoomDB
    {
        DBConnection connection = new DBConnection();
        // Nhận ID và kiểm tra phòng máy tính có tồn tại với Id đó hay không, nếu có trả về true, nếu không trả về false
        public bool IsComputerRoomExistsByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM computer_room WHERE id = @id", connection.getConnection);
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

        // Hàm thêm thông tin phòng máy tính vào DB, trả về true nếu thêm thành công, false nếu thêm không thành công
        public bool AddNewComputerRoom(int roomID, int floor, int compNum, string status, int max_comp_num)
        {
            SqlCommand command = new SqlCommand("INSERT INTO computer_room (id, floor, compNum, status, max_comp_num)"
                + " VALUES (@id, @floor, @compNum, @status, @max_comp_num)", connection.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@floor", SqlDbType.Int).Value = floor;
            command.Parameters.Add("@compNum", SqlDbType.VarChar).Value = compNum;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@max_comp_num", SqlDbType.Int).Value = max_comp_num;
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
            catch
            {
                return false;
            }
        }
        // Trả về một data table của quan hệ computer_room
        public DataTable GetAllRooms()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM computer_room", connection.getConnection);
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        // Hàm trả về số phòng trong db

        public int RoomCount()
        {
            SqlCommand command = new SqlCommand("SELECT count(*) FROM computer_room", connection.getConnection);
            connection.openConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.closeConnection();
            return count;
        }

        // Hàm số phòng bằng id, trả về true nếu xóa thành công, false nếu xóa không thành công.

        public bool DeleteComputerRoom(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM computer_room WHERE id = @id", connection.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        // Hàm lấy số máy tính tối đa của phòng
        public int GetMaxComputerCapacity(int id)
        {
            int capacity = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM computer_room WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    capacity = Int32.Parse(reader["max_comp_num"].ToString());
                }
                reader.Close();
                connection.closeConnection();
                return capacity;
            }
            catch
            {
                return capacity;
            }
        }

        // Hàm lấy số máy tính hiện tại
        public int GetComputerCount(int id)
        {
            int count = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM computer_room WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count = Int32.Parse(reader["compNum"].ToString());
                }
                reader.Close();
                connection.closeConnection();
                return count;
            }
            catch
            {
                return count;
            }
        }
    }
}
