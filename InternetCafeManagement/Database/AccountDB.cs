using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetCafeManagement.Utility;
namespace InternetCafeManagement.Database
{
    class AccountDB
    {
        DBConnection connection = new DBConnection();

        // Hàm đăng ký tài khoản mới, trả vể true nếu đăng ký thành công, trả về false nếu đăng ký thất bại
        public bool register(string name, string gender, string phone, string email, string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO account (id, name, gender, phone, balance, email, username, password)"
                + " VALUES ((SELECT MAX(id) FROM account) + 1, @name, @gender, @phone, @balance, @email, @username, @password)", connection.getConnection);

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
            catch
            {
                int id = 1;
                command = new SqlCommand("INSERT INTO account (id, name, gender, phone, balance, email, username, password)"
                + " VALUES (@id, @name, @gender, @phone, @balance, @email, @username, @password)", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
                catch
                {
                    return false;
                }
            }
        }       
        
        // Hàm cập nhật thông tin căn bản của người dùng
        public bool updateUserData(int ID, string fullname, string gender, string phone, string email)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE account SET name = @name, gender = @gender, email = @email, phone = @phone WHERE id = @id", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = fullname;
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

                connection.openConnection();
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
        // Hàm cập nhật mật khẩu cho người dùng
        public bool updatePassword(int id, string password)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE account SET password = @password WHERE id = @id", connection.getConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                connection.openConnection();
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
        // Hàm lấy ID của User hiện tại
        public int getUserID(string username)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE username = @username", connection.getConnection);
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Int32.Parse(reader["id"].ToString());
                }
                reader.Close();
                connection.closeConnection();
                return id;
            }
            catch
            {
                return id;
            }
        }
        public string getUserFullName()
        {
            string username = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = CurrentUser.Id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    username = reader["name"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return username;
            }
            catch
            {
                return username;
            }
        }
        public string getUserPhone()
        {
            string phone = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = CurrentUser.Id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    phone = reader["phone"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return phone;
            }
            catch
            {
                return phone;
            }
        }
        public string getUserEmail()
        {
            string email = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = CurrentUser.Id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    email = reader["email"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return email;
            }
            catch
            {
                return email;
            }
        }
        public string getUsername()
        {
            string username = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = CurrentUser.Id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    username = reader["username"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return username;
            }
            catch
            {
                return username;
            }
        }
        public string getUserPassword()
        {
            string password = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = CurrentUser.Id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    password = reader["password"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return password;
            }
            catch
            {
                return password;
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
        // Hàm kiểm tra mật khẩu của người dùng có số id đó, trả về true nếu nhập đúng mật khẩu, trả về false nếu sai mật khẩu khớp với id đó.
        public bool passwordCheck(int id, string password)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM account WHERE id = @id and password = @password ", connection.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

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
        // Hàm lấy giới tính của người dùng bằng ID hiện tại
        public string GetUserGender()
        {
            string gender = String.Empty;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE id = @id", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = CurrentUser.Id;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gender = reader["gender"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return gender;
            }
            catch
            {
                return null;
            }
        }
    }
}
