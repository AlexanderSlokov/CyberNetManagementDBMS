using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.Database
{
    class DBConnection
    {
        private const string connectionString = "Data Source=DESKTOP-OB2KPUE;Initial Catalog=InternetCafeDB;Integrated Security=True";
        private string role;

        // Phần data source này các bạn MySQL server lấy tên của server  máy local để vào dưới, mỗi máy khác nhau
        private SqlConnection con;

        public DBConnection()
        {
            this.con = new SqlConnection(@"Data Source=DESKTOP-OB2KPUE;Initial Catalog=InternetCafeDB;Integrated Security=True");
            this.role = CurrentUser.Role;
            

        }
        public void GetPermission()
        {
            if (role == "user")
            {
                ExecuteEnableUserAppRole();
            }
            else if (role == "employee")
            {
                ExecuteEnableEmployeeAppRole();
            }
            else if (role == "manager")
            {
                ExecuteEnableManagerAppRole();
            }
            if (role == null)
            {
                role = CurrentUser.LoginRequest;
                if (role == "user")
                {
                    ExecuteEnableUserAppRole();
                }
                else if (role == "employee")
                {
                    ExecuteEnableEmployeeAppRole();
                }
            }
        }
        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {   
                con.Open();
            }
        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
        public bool ExecuteEnableUserAppRole()
        {
            
            string procName = "sp_setapprole";
            bool result = true;


            SqlCommand cmd = new SqlCommand(procName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.getConnection;

            SqlParameter paramAppRoleName = new SqlParameter();
            paramAppRoleName.Direction = ParameterDirection.Input;
            paramAppRoleName.ParameterName = "@rolename";
            paramAppRoleName.Value = "user";
            cmd.Parameters.Add(paramAppRoleName);

            SqlParameter paramAppRolePwd = new SqlParameter();
            paramAppRolePwd.Direction = ParameterDirection.Input;
            paramAppRolePwd.ParameterName = "@password";
            paramAppRolePwd.Value = "12345";
            cmd.Parameters.Add(paramAppRolePwd);

            SqlParameter paramEncrypt = new SqlParameter();
            paramEncrypt.Direction = ParameterDirection.Input;
            paramEncrypt.ParameterName = "@encrypt";
            paramEncrypt.Value = "none";
            cmd.Parameters.Add(paramEncrypt);

            try
            {
                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
        public bool ExecuteEnableEmployeeAppRole()
        {
            string procName = "sp_setapprole";
            bool result = true;


            SqlCommand cmd = new SqlCommand(procName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.getConnection;

            SqlParameter paramAppRoleName = new SqlParameter();
            paramAppRoleName.Direction = ParameterDirection.Input;
            paramAppRoleName.ParameterName = "@rolename";
            paramAppRoleName.Value = "employee";
            cmd.Parameters.Add(paramAppRoleName);

            SqlParameter paramAppRolePwd = new SqlParameter();
            paramAppRolePwd.Direction = ParameterDirection.Input;
            paramAppRolePwd.ParameterName = "@password";
            paramAppRolePwd.Value = "12345";
            cmd.Parameters.Add(paramAppRolePwd);

            SqlParameter paramEncrypt = new SqlParameter();
            paramEncrypt.Direction = ParameterDirection.Input;
            paramEncrypt.ParameterName = "@encrypt";
            paramEncrypt.Value = "none";
            cmd.Parameters.Add(paramEncrypt);

            try
            {
                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
        public bool ExecuteEnableManagerAppRole()
        {
            string procName = "sp_setapprole";
            bool result = true;


            SqlCommand cmd = new SqlCommand(procName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.getConnection;

            SqlParameter paramAppRoleName = new SqlParameter();
            paramAppRoleName.Direction = ParameterDirection.Input;
            paramAppRoleName.ParameterName = "@rolename";
            paramAppRoleName.Value = "manager";
            cmd.Parameters.Add(paramAppRoleName);

            SqlParameter paramAppRolePwd = new SqlParameter();
            paramAppRolePwd.Direction = ParameterDirection.Input;
            paramAppRolePwd.ParameterName = "@password";
            paramAppRolePwd.Value = "12345";
            cmd.Parameters.Add(paramAppRolePwd);

            SqlParameter paramEncrypt = new SqlParameter();
            paramEncrypt.Direction = ParameterDirection.Input;
            paramEncrypt.ParameterName = "@encrypt";
            paramEncrypt.Value = "none";
            cmd.Parameters.Add(paramEncrypt);

            try
            {
                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
        
    }
}
