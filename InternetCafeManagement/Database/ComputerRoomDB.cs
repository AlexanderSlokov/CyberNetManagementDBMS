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
        public bool AddNewComputerRoom(int roomID, int floor, int compNum, string status)
        {
            SqlCommand command = new SqlCommand("INSERT INTO computer_room (id, floor, compNum, status)"
                + " VALUES (@id, @floor, @compNum, @status)", connection.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("@floor", SqlDbType.Int).Value = floor;
            command.Parameters.Add("@compNum", SqlDbType.VarChar).Value = compNum;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
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
    }
}
