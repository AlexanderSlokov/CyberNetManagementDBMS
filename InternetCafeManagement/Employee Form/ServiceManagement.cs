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
    public partial class ServiceManagement : UserControl
    {
        public ServiceManagement()
        {
            InitializeComponent();
        }
        OrderDB orderDB = new OrderDB();
        RechargeDB rechargeDB = new RechargeDB();
        void LoadData()
        {
            dataGridViewOrderList.DataSource = orderDB.GetDataTableAllOrders();

            dataGridViewOrderList.RowTemplate.Height = 50;
            dataGridViewOrderList.RowHeadersVisible = false;
            dataGridViewOrderList.AllowUserToAddRows = false;
        }
        private void ServiceManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int user_id;
            try
            {
                user_id = Int32.Parse(dataGridViewOrderList.CurrentRow.Cells["User ID"].Value.ToString());
            }
            catch
            {
                user_id = 0;
            }
            int service_id;
            try
            {
                service_id = Int32.Parse(dataGridViewOrderList.CurrentRow.Cells["Service ID"].Value.ToString());
            }
            catch
            {
                service_id = 0;
            }
            int quantity;
            try
            {
                quantity = Int32.Parse(dataGridViewOrderList.CurrentRow.Cells["Quantity"].Value.ToString());
            }
            catch
            {
                quantity = 0;
            }
            string service_name;
            service_name = dataGridViewOrderList.CurrentRow.Cells["Service Name"].Value.ToString();
            float amount;
            try
            {
                amount =  float.Parse(dataGridViewOrderList.CurrentRow.Cells["Price"].Value.ToString());
            }
            catch
            {
                amount = 0;
            }
            if (MessageBox.Show("Confirm Order Deliveried At User ID =" + user_id + " with Service Name = " + service_name, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                orderDB.DeleteOrder(service_id, user_id);
                rechargeDB.RechargeForUser(user_id, (float) ( (float) quantity * (- amount)) );
                LoadData();
            }
            else
            {
                // user clicked no
            }
        }
    }
}
