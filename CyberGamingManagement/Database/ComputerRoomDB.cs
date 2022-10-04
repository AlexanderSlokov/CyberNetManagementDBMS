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
    
    public class ComputerRoomDB
    {
        DBConnection connection = new DBConnection();
        // Nhận ID và kiểm tra phòng máy tính có tồn tại với Id đó hay không, nếu có trả về true, nếu không trả về false
        public bool IsComputerRoomExistsByID(int id)
        {
            SqlCommand command = new SqlCommand("pr_IsComputerRoomExistsByID", connection.getConnection);
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

        // Hàm thêm thông tin phòng máy tính vào DB, trả về true nếu thêm thành công, false nếu thêm không thành công
        public bool AddNewComputerRoom(int roomID, int floor, int compNum, int max_comp_num)
        {
            SqlCommand command = new SqlCommand("pr_AddNewComputerRoom", connection.getConnection);
            if(roomID == 0)
            {
                MessageBox.Show("Please Enter Room ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@id", SqlDbType.Int).Value = roomID;
            if (floor == 0)
            {
                MessageBox.Show("Please Enter Floor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@floor", SqlDbType.Int).Value = floor;
            command.Parameters.Add("@compNum", SqlDbType.VarChar).Value = compNum;
            if (max_comp_num == 0)
            {
                MessageBox.Show("Please Enter Room Capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@max_comp_num", SqlDbType.Int).Value = max_comp_num;
            command.CommandType = CommandType.StoredProcedure;
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
        // Trả về một data table của quan hệ computer_room
        public DataTable GetAllRooms()
        {
            SqlCommand command = new SqlCommand("pr_GetAllRooms", connection.getConnection);
            connection.openConnection();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }

        // Hàm trả về số phòng trong db
        public List<int> GetRoomIDList()
        {
            List<int> roomIDList = new List<int>();
            SqlCommand command = new SqlCommand("pr_GetAllRooms", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Int32.Parse(reader["id"].ToString());
                roomIDList.Add(id);
            }
            connection.closeConnection();
            return roomIDList;
        }
        public int RoomCount()
        {
            SqlCommand command = new SqlCommand("pr_RoomCount", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            connection.openConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.closeConnection();
            return count;
        }

        // Hàm số phòng bằng id, trả về true nếu xóa thành công, false nếu xóa không thành công.

        public bool DeleteComputerRoom(int id)
        {
            SqlCommand command = new SqlCommand("pr_DeleteComputerRoom", connection.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.CommandType = CommandType.StoredProcedure;
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
                SqlCommand command = new SqlCommand("pr_GetMaxComputerCapacity", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;
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
                SqlCommand command = new SqlCommand("pr_GetComputerCount", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;
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
