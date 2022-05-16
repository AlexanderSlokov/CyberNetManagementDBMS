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
        private byte[] _appRoleEnableCookie;

        // Phần data source này các bạn MySQL server lấy tên của server  máy local để vào dưới, mỗi máy khác nhau
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OB2KPUE;Initial Catalog=InternetCafeDB;Integrated Security=True");

        public DBConnection()
        {
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
                
                if (CurrentUser.LoginRequest == "user")
                {
                    ExecuteEnableUserAppRole();
                }
                else if (CurrentUser.LoginRequest == "employee")
                {
                    ExecuteEnableEmployeeAppRole();
                }
                else if (CurrentUser.LoginRequest == "manager")
                {
                    ExecuteEnableManagerAppRole();
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
                GetPermission();
            }
        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                DisablePermission();
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

            SqlParameter paramCreateCookie = new SqlParameter();
            paramCreateCookie.Direction = ParameterDirection.Input;
            paramCreateCookie.ParameterName = "@fCreateCookie";
            paramCreateCookie.DbType = DbType.Boolean;
            paramCreateCookie.Value = 1;
            cmd.Parameters.Add(paramCreateCookie);

            SqlParameter paramEncrypt = new SqlParameter();
            paramEncrypt.Direction = ParameterDirection.Input;
            paramEncrypt.ParameterName = "@encrypt";
            paramEncrypt.Value = "none";
            cmd.Parameters.Add(paramEncrypt);

            SqlParameter paramEnableCookie = new SqlParameter();
            paramEnableCookie.ParameterName = "@cookie";
            paramEnableCookie.DbType = DbType.Binary;
            paramEnableCookie.Direction = ParameterDirection.Output;
            paramEnableCookie.Size = 1000;
            cmd.Parameters.Add(paramEnableCookie);

            try
            {
                cmd.ExecuteNonQuery();
                SqlParameter outVal = cmd.Parameters["@cookie"];
                // Store the enabled cookie so that approle  can be disabled with the cookie.
                _appRoleEnableCookie = (byte[])outVal.Value;
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
            paramAppRolePwd.Value = "employee12345";
            cmd.Parameters.Add(paramAppRolePwd);

            SqlParameter paramCreateCookie = new SqlParameter();
            paramCreateCookie.Direction = ParameterDirection.Input;
            paramCreateCookie.ParameterName = "@fCreateCookie";
            paramCreateCookie.DbType = DbType.Boolean;
            paramCreateCookie.Value = 1;
            cmd.Parameters.Add(paramCreateCookie);

            SqlParameter paramEncrypt = new SqlParameter();
            paramEncrypt.Direction = ParameterDirection.Input;
            paramEncrypt.ParameterName = "@encrypt";
            paramEncrypt.Value = "none";
            cmd.Parameters.Add(paramEncrypt);

            SqlParameter paramEnableCookie = new SqlParameter();
            paramEnableCookie.ParameterName = "@cookie";
            paramEnableCookie.DbType = DbType.Binary;
            paramEnableCookie.Direction = ParameterDirection.Output;
            paramEnableCookie.Size = 1000;
            cmd.Parameters.Add(paramEnableCookie);

            try
            {
                cmd.ExecuteNonQuery();
                SqlParameter outVal = cmd.Parameters["@cookie"];
                // Store the enabled cookie so that approle  can be disabled with the cookie.
                _appRoleEnableCookie = (byte[])outVal.Value;
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
            paramAppRolePwd.Value = "manager123456789";
            cmd.Parameters.Add(paramAppRolePwd);

            SqlParameter paramCreateCookie = new SqlParameter();
            paramCreateCookie.Direction = ParameterDirection.Input;
            paramCreateCookie.ParameterName = "@fCreateCookie";
            paramCreateCookie.DbType = DbType.Boolean;
            paramCreateCookie.Value = 1;
            cmd.Parameters.Add(paramCreateCookie);

            SqlParameter paramEncrypt = new SqlParameter();
            paramEncrypt.Direction = ParameterDirection.Input;
            paramEncrypt.ParameterName = "@encrypt";
            paramEncrypt.Value = "none";
            cmd.Parameters.Add(paramEncrypt);

            SqlParameter paramEnableCookie = new SqlParameter();
            paramEnableCookie.ParameterName = "@cookie";
            paramEnableCookie.DbType = DbType.Binary;
            paramEnableCookie.Direction = ParameterDirection.Output;
            paramEnableCookie.Size = 1000;
            cmd.Parameters.Add(paramEnableCookie);
            try
            {
                cmd.ExecuteNonQuery();
                SqlParameter outVal = cmd.Parameters["@cookie"];
                // Store the enabled cookie so that approle  can be disabled with the cookie.
                _appRoleEnableCookie = (byte[])outVal.Value;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
        public void DisablePermission()
        {
            string procName = "sp_unsetapprole";

            SqlCommand cmd = new SqlCommand(procName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.getConnection;

            SqlParameter paramEnableCookie = new SqlParameter();
            paramEnableCookie.Direction = ParameterDirection.Input;
            paramEnableCookie.ParameterName = "@cookie";
            paramEnableCookie.Value = this._appRoleEnableCookie;
            cmd.Parameters.Add(paramEnableCookie);

            try
            {
                cmd.ExecuteNonQuery();
                _appRoleEnableCookie = null;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
