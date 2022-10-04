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

namespace CyberGamingManagement.Database
{
    public class ServiceDB
    {
        DBConnection connection = new DBConnection();
        public bool InsertService(int id, string name, string description, float price, Image picture)
        {

            SqlCommand command = new SqlCommand("pr_InsertService", connection.getConnection);
            if (id == 0)
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            if (name == String.Empty)
            {
                MessageBox.Show("Please Enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
            if(price == 0)
            {
                MessageBox.Show("Please Enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@price", SqlDbType.Real).Value = price;

            MemoryStream memoryStream = new MemoryStream();
            if (picture != null)
            {
                picture.Save(memoryStream, picture.RawFormat);
                command.Parameters.Add("@picture", SqlDbType.Image).Value = memoryStream.ToArray();
            }
            else
            {
                command.Parameters.Add("@picture", SqlDbType.Image).Value = DBNull.Value;
            }

            command.CommandType = CommandType.StoredProcedure;

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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;

            }
        }
        public bool isServiceExists(int id)
        {
            SqlCommand command = new SqlCommand("pr_isServiceExsists", connection.getConnection);
            if (id == 0)
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
        public DataTable GetDataTableAllServices()
        {
            SqlCommand command = new SqlCommand("pr_SelectAllServices", connection.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Connection = connection.getConnection;
            connection.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "std");

            dataTable = dataSet.Tables["std"];

            connection.closeConnection();
            return dataTable;
        }

        public bool DeleteService(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteService", connection.getConnection);
                if (id == 0)
                {
                    MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;
                connection.openConnection();
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

    }
}

