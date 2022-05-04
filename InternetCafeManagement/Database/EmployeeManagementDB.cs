using InternetCafeManagement.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Database
{
    public class EmployeeManagementDB
    {
        DBConnection connection = new DBConnection();

        SqlDataAdapter dataAdapter; // sẽ truy xuất dữ liệu vào bảng 
        SqlCommand sqlCommand;// dùng để truy vấn và cập nhật tới dữ liệu

        public EmployeeManagementDB(){}

        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();

            string query = "select * from employeemanagement";
           
               
            dataAdapter = new SqlDataAdapter(query, connection.getConnection);
            dataAdapter.Fill (dataTable);
            return dataTable;   
        }

        public bool insertNhanVien(NhanVien nhanVien)
        {
            string query = "insert into employeemanagement values (@MaNV, @TenNV, @GioiTinh, @NgaySinh, @DiaChi, @DienThoai)"; 

            try
            {
                connection.openConnection();
                sqlCommand = new SqlCommand(query, connection.getConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nhanVien.Id;
                sqlCommand.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanVien.Name;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.Sex;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.DateOfBirth.ToShortDateString();// chi lay ngay thanh nam
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.Address;
                sqlCommand.Parameters.Add("@DienThoai", SqlDbType.Int).Value = nhanVien.PhoneNumber;
                sqlCommand.ExecuteNonQuery();// thuc thi lenh truy van 
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.closeConnection();   
            }
            return true;
        }
        public bool updateNhanVien(NhanVien nhanVien)
        {
            string query = "update employeemanagement set TenNV = @TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, DienThoai = @DienThoai where MaNV = @MaNV";

            try
            {
                connection.openConnection();
                sqlCommand = new SqlCommand(query, connection.getConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nhanVien.Id;
                sqlCommand.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanVien.Name;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.Sex;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.DateOfBirth.ToShortDateString();// chi lay ngay thanh nam
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.Address;
                sqlCommand.Parameters.Add("@DienThoai", SqlDbType.Int).Value = nhanVien.PhoneNumber;
                sqlCommand.ExecuteNonQuery();// thuc thi lenh truy van 
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.closeConnection();
            }
            return true;
        }
        public bool deleteNhanVien(string id)
        {
            string query = "delete employeement where MaNV = @MaNV";

            try
            {
                connection.openConnection();
                sqlCommand = new SqlCommand(query, connection.getConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = id;
               
                sqlCommand.ExecuteNonQuery();// thuc thi lenh truy van 
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.closeConnection();
            }
            return true;
        }
    }
}
