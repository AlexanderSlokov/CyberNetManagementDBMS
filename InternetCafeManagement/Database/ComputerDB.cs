using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if ((command.ExecuteNonQuery() == 1))
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
    }
}
