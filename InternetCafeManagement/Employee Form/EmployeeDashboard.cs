using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Database;

namespace InternetCafeManagement.Employee_Form
{
    public partial class EmployeeDashboard : UserControl
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }
        RechargeDB rechargeDB = new RechargeDB();
        AccountDB accountDB = new AccountDB();
        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dataGridViewRechargeRequest.RowHeadersVisible = false;
            dataGridViewRechargeRequest.AllowUserToAddRows = false;
            dataGridViewRechargeRequest.DataSource = rechargeDB.GetAllRechargeRequests();
            dataGridViewRechargeRequest.Columns[0].Width = 0;
            dataGridViewRechargeRequest.Columns[0].HeaderText = "ID";
        }

        private void dataGridViewRechargeRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int user_id;
            try
            {
                user_id = Int32.Parse(dataGridViewRechargeRequest.CurrentRow.Cells["ID"].Value.ToString());
            }
            catch
            {
                user_id = 0;
            }

            float amount;
            try
            {
                amount = float.Parse(dataGridViewRechargeRequest.CurrentRow.Cells["Amount"].Value.ToString());
            }
            catch
            {
                amount = 0;
            }
            int recharg_id;
            try
            {
                recharg_id = Int32.Parse(dataGridViewRechargeRequest.CurrentRow.Cells["Recharge ID"].Value.ToString());
            }
            catch
            {
                recharg_id = 0;
            }
            if (MessageBox.Show("Confirm Recharge At ID =" + user_id + " with amount = " + amount, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rechargeDB.DeleteRecharge(recharg_id);
                rechargeDB.RechargeForUser(user_id, amount);
                LoadData();
            }
            else
            {
                // user clicked no
            }
        }
    }
}
