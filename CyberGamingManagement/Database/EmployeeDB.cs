using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberGamingManagement.Model;
using CyberGamingManagement.Utility;

namespace CyberGamingManagement.Database
{
    public class EmployeeDB
    {
        DBConnection connection = new DBConnection();
        public bool login(string username, string password)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("pr_EmployeeLogin", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            connection.openConnection();
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
        public Employee GetEmployeeByID(int id)
        {
            Employee employee = new Employee();
            try
            {
                SqlCommand command = new SqlCommand("pr_GetEmployeeByID", connection.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        employee.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        employee.Image = null;
                    }
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                employee.SetAge();
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Employee GetEmployeeByUsername(string username)
        {

            Employee employee = new Employee();
            try
            {
                SqlCommand command = new SqlCommand("pr_GetEmployeeByUsername", connection.getConnection);
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        employee.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        employee.Image = null;
                    }
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool UpdateEmployee(Employee employee, int oldID, string oldUsername)
        {

            if (employee.Id == 0)
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmployeeExistByID(employee.Id) && employee.Id != oldID)
            {
                MessageBox.Show("ID existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(employee.Id == oldID)
            {
                // Update
                SqlCommand command = new SqlCommand("pr_UpdateEmployee", connection.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = employee.Id;
                command.CommandType = CommandType.StoredProcedure;
                if (employee.Name == String.Empty || employee.Name == null)
                {
                    MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = employee.Name;
                if (employee.Position == String.Empty || employee.Position == null)
                {
                    MessageBox.Show("Please Enter Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@position", SqlDbType.VarChar).Value = employee.Position;
                command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = employee.BirthDate;
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = employee.Gender;
                if (employee.PhoneNum == String.Empty || employee.PhoneNum == null)
                {
                    MessageBox.Show("Please Enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@phoneNum", SqlDbType.VarChar).Value = employee.PhoneNum;
                if (employee.Email == String.Empty || employee.Email == null || DataValidate.emailValidate(employee.Email) == false)
                {
                    MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = employee.Email;

                MemoryStream memoryStream = new MemoryStream();
                if (employee.Image != null)
                {
                    employee.Image.Save(memoryStream, employee.Image.RawFormat);
                    command.Parameters.Add("@image", SqlDbType.Image).Value = memoryStream.ToArray();
                }
                else
                {
                    command.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value;
                }
                if (employee.Salary_per_hour == 0)
                {
                    MessageBox.Show("Please Enter Salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@salary_per_hour", SqlDbType.Real).Value = employee.Salary_per_hour;
                if (employee.Username == String.Empty || employee.Username == null)
                {
                    MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (this.IsEmployeeExistByUsername(employee.Username) == true && employee.Username != oldUsername)
                {
                    MessageBox.Show("Username Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = employee.Username;
                if (employee.Password == String.Empty || employee.Password == null)
                {
                    MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = employee.Password;


                connection.openConnection();
                try
                {
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        MessageBox.Show("Update New Employee Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.closeConnection();
                        return true;

                    }
                    else
                    {
                        connection.closeConnection();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (employee.Id != oldID)
            {
                // Delete Old ID
                this.DeleteEmployee(oldID);
                // Insert
                this.AddEmployee(employee);
            }
            return false;
        }

        public bool AddEmployee(Employee employee)
        {
            SqlCommand command = new SqlCommand("pr_AddEmployee", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            if (employee.Id == 0)
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmployeeExistByID(employee.Id))
            {
                MessageBox.Show("ID existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@id", SqlDbType.Int).Value = employee.Id;
            if (employee.Name == String.Empty || employee.Name == null)
            {
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = employee.Name;
            if (employee.Position == String.Empty || employee.Position == null)
            {
                MessageBox.Show("Please Enter Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@position", SqlDbType.VarChar).Value = employee.Position;
            command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = employee.BirthDate;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = employee.Gender;
            if (employee.PhoneNum == String.Empty || employee.PhoneNum == null)
            {
                MessageBox.Show("Please Enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@phoneNum", SqlDbType.VarChar).Value = employee.PhoneNum;
            if (employee.Email == String.Empty || employee.Email == null || DataValidate.emailValidate(employee.Email) == false)
            {
                MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = employee.Email;

            MemoryStream memoryStream = new MemoryStream();
            if(employee.Image != null)
            {
                employee.Image.Save(memoryStream, employee.Image.RawFormat);
                command.Parameters.Add("@image", SqlDbType.Image).Value = memoryStream.ToArray();
            }
            else
            {
                command.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value;
            }
            if (employee.Salary_per_hour == 0)
            {
                MessageBox.Show("Please Enter Salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@salary_per_hour", SqlDbType.Real).Value = employee.Salary_per_hour;
            if (employee.Username == String.Empty || employee.Username == null)
            {
                MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(this.IsEmployeeExistByUsername(employee.Username) == true)
            {
                MessageBox.Show("Username Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = employee.Username;
            if (employee.Password == String.Empty || employee.Password == null)
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = employee.Password;


            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Insert New Employee Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    return true;

                }
                else
                {
                    connection.closeConnection();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool IsEmployeeExistByID(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("pr_IsEmployeeExistByID", connection.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.CommandType = CommandType.StoredProcedure;
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
        public bool IsEmployeeExistByUsername(string username)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("pr_IsEmployeeExistByUsername", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            adapter.SelectCommand = command;
            connection.openConnection();
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
        public DataTable GetEmployeesDataTable()
        {
            SqlCommand command = new SqlCommand("pr_GetEmployeesDataTable", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "employee";
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        public DataTable GetManagersDataTable()
        {

            SqlCommand command = new SqlCommand("pr_GetManagersDataTable", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "manager";
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        public List<Employee> GetManagersList()
        {
            List<Employee> employeeList = new List<Employee>();
            try
            {
                SqlCommand command = new SqlCommand("pr_GetManagersList", connection.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "manager";

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        employee.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        employee.Image = null;
                    }
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                    employeeList.Add(employee);
                }
                reader.Close();
                connection.closeConnection();
                return employeeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Employee> GetEmployeesList()
        {
            List<Employee> employeeList = new List<Employee>();
            try
            {
                SqlCommand command = new SqlCommand("pr_GetEmployeesList", connection.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "employee";
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        employee.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        employee.Image = null;
                    }
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                    employeeList.Add(employee);
                }
                reader.Close();
                connection.closeConnection();
                return employeeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Stack<Employee> GetEmployeesStack()
        {
            Stack<Employee> employeesStack = new Stack<Employee>();
            try
            {
                SqlCommand command = new SqlCommand("pr_GetEmployeesList", connection.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "employee";
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        employee.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        employee.Image = null;
                    }
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                    employeesStack.Push(employee);
                }
                reader.Close();
                connection.closeConnection();
                return employeesStack;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool DeleteEmployee(int ID)
        {
            SqlCommand command = new SqlCommand("pr_DeleteEmployee", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() >= 1))
                {
                    // Delete thanh cong
                    //MessageBox.Show("De New Employee Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    return true;
                }
                else
                {
                    // nguoc lai
                    connection.closeConnection();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable GetAllSalaryDataTable()
        {

            SqlCommand command = new SqlCommand("pr_TableAllSalary", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        public int CountEmployeesNumber()
        {
            int count = 0;
            SqlCommand command = new SqlCommand("pr_NumberOfEmployees", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            connection.openConnection();
            try
            {
                count = Int32.Parse(command.ExecuteScalar().ToString());
                connection.closeConnection();
                return count;
            }
            catch
            {
                return 0;
            }
        }
        public int CountManagersNumber()
        {
            int count = 0;
            SqlCommand command = new SqlCommand("pr_NumberOfManagers", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            connection.openConnection();
            try
            {

                count = Int32.Parse(command.ExecuteScalar().ToString());
                connection.closeConnection();
                return count;
            }
            catch
            {
                connection.closeConnection();
                return 0;
            }
        }
    }
}
