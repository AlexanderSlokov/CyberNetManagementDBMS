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
    public class RechargeDB
    {
        DBConnection connection = new DBConnection();
        public bool InsertRecharge(int account_id, float amount)
        {

            SqlCommand command = new SqlCommand("pr_InsertRecharge", connection.getConnection);
            if (account_id == 0)
            {
                MessageBox.Show("Please Enter account_id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@account_id", SqlDbType.Int).Value = account_id;
            if (amount == 0)
            {
                MessageBox.Show("Please Enter ammount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@amount", SqlDbType.Real).Value = amount;
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
        public bool DeleteRecharge(int recharge_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteRecharge", connection.getConnection);

                if (recharge_id == 0)
                {
                    MessageBox.Show("Please Enter account_id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@id", SqlDbType.Int).Value = recharge_id;

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
        public DataTable GetAllRechargeRequests()
        {
            SqlCommand command = new SqlCommand("pr_GetAllRechargeRequests", connection.getConnection);
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
        public bool RechargeForUser(int account_id, float amount)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_RechargeForUser", connection.getConnection);

                if (account_id == 0)
                {
                    MessageBox.Show("Please Enter account_id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@account_id", SqlDbType.Int).Value = account_id;
                if (amount == 0)
                {
                    MessageBox.Show("Please Enter ammount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@amount", SqlDbType.Real).Value = amount;
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
