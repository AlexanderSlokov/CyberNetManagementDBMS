using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Class
{
    class Account
    {
        DBConnection connection = new DBConnection();
        // Hàm đăng ký tài khoản mới, trả vể true nếu đăng ký thành công, trả về false nếu đăng ký thất bại
        public bool register(string name, string email, string phone, string username, string password)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO account (id, name, email, phone, username, password)"
                + " VALUES ((SELECT MAX(id) FROM account) + 1, @name, @email, @phone,@username, @password)", connection.getConnection);

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
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
                catch
                {
                    return false;
                }
            }
            catch
            {
                int id = 1;
                SqlCommand command = new SqlCommand("INSERT INTO account (id, name, email, phone, username, password)"
                + " VALUES (@id, @name, @email, @phone,@username, @password)", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
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
                catch
                {
                    return false;
                }
            }
            
        }
        // Hàm đăng nhập, kiểm tra tên tài khoản và mật khẩu
        public bool login(string username, string password)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM account WHERE username = @User AND password = @Pass", connection.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            connection.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
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
        // Hàm kiểm tra User có tồn tài chưa, bằng cách kiểm tra ID được truyền vào, nếu tồn tại Trả về "TRUE", nếu không tồn tại trả vể "False"
        public bool isUserExist_By_ID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE id = @id", connection.getConnection);
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
        // Hàm kiểm tra User có tồn tài chưa, bằng cách kiểm tra username được truyền vào, nếu tồn tại Trả về "TRUE", nếu không tồn tại trả vể "False"
        public bool isUserExist_By_Username(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @username", connection.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

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
