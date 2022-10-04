using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberGamingManagement.Database
{
    public class OrderDB
    {
        DBConnection connection = new DBConnection();
        public bool InsertOrder(int service_id, int account_id, int quantity)
        {

            SqlCommand command = new SqlCommand("pr_InsertOrder", connection.getConnection);
            if (service_id == 0)
            {
                MessageBox.Show("Please Enter Service ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@service_id", SqlDbType.Int).Value = service_id;
            if (account_id == 0)
            {
                MessageBox.Show("Please Enter User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@account_id", SqlDbType.Int).Value = account_id;
            if (quantity == 0)
            {
                MessageBox.Show("Please Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

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
        public bool isOrderExists(int service_id, int account_id)
        {
            SqlCommand command = new SqlCommand("pr_isOrderExsists", connection.getConnection);
            if (service_id == 0)
            {
                MessageBox.Show("Please Enter Service ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@service_id", SqlDbType.Int).Value = service_id;
            if (account_id == 0)
            {
                MessageBox.Show("Please Enter User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@account_id", SqlDbType.Int).Value = account_id;
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
        public DataTable GetDataTableAllOrders()
        {
            SqlCommand command = new SqlCommand("pr_SelectAllOrders", connection.getConnection);
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
        public DataTable GetDataTableAllOrdersOfUser(int account_id)
        {
            SqlCommand command = new SqlCommand("pr_SelectAllOrdersOfUser", connection.getConnection);
            if (account_id == 0)
            {
                MessageBox.Show("Please Enter User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@account_id", SqlDbType.Int).Value = account_id;
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
        public bool DeleteOrder(int service_id, int account_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteOrder", connection.getConnection);
                if (service_id == 0)
                {
                    MessageBox.Show("Please Enter Service ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@service_id", SqlDbType.Int).Value = service_id;
                if (account_id == 0)
                {
                    MessageBox.Show("Please Enter Account ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@account_id", SqlDbType.Int).Value = account_id;
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
