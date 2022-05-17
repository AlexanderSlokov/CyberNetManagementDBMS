using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Database;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.User_Form
{
    public partial class UserService : UserControl
    {
        public UserService()
        {
            InitializeComponent();
        }
        OrderDB orderDB = new OrderDB();
        ServiceDB serviceDB = new ServiceDB();
        private void buttonNewService_Click(object sender, EventArgs e)
        {
            Add();
        }
        void Add()
        {
            int service_id;
            try
            {
                service_id = Int32.Parse(textBoxServiceID.Text.ToString());
            }
            catch
            {
                service_id = 0;
            }
            int quantity;
            try
            {
                quantity = Int32.Parse(textBoxQuantity.Text.ToString());
            }
            catch
            {
                quantity = 0;
            }
            if (orderDB.isOrderExists(service_id, CurrentUser.Id) == false)
            {
                if (orderDB.InsertOrder(service_id, CurrentUser.Id, quantity))
                {
                    MessageBox.Show("Order Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();

                }
                else
                {
                    MessageBox.Show("Failed To Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void LoadData()
        {
            textBoxQuantity.Text = "1";
            textBoxServiceID.ReadOnly = false; textBoxServiceName.ReadOnly = false;
            textBoxServiceName.ReadOnly = false;

            dataGridViewService.DataSource = serviceDB.GetDataTableAllServices();
            dataGridViewService.RowTemplate.Height = 50;
            dataGridViewService.RowHeadersVisible = false;
            dataGridViewService.AllowUserToAddRows = false;

            dataGridViewService.Columns["id"].Width = 70;
            dataGridViewService.Columns["id"].HeaderText = "ID";

            dataGridViewService.Columns["name"].Width = 70;
            dataGridViewService.Columns["name"].HeaderText = "Name";

            dataGridViewService.Columns["description"].Width = 150;
            dataGridViewService.Columns["description"].HeaderText = "Description";

            dataGridViewService.Columns["price"].Width = 100;
            dataGridViewService.Columns["price"].HeaderText = "Price";

            dataGridViewService.Columns["picture"].Width = 300;
            dataGridViewService.Columns["picture"].HeaderText = "Image";
        }
        private void UserService_Load(object sender, EventArgs e)
        {
            textBoxQuantity.Text = "1";
            LoadData();
        }

        private void dataGridViewService_Click(object sender, EventArgs e)
        {
            textBoxServiceID.Text = dataGridViewService.CurrentRow.Cells["id"].Value.ToString().Trim();
            textBoxServiceName.Text = dataGridViewService.CurrentRow.Cells["name"].Value.ToString().Trim();
            textBoxDescription.Text = dataGridViewService.CurrentRow.Cells["description"].Value.ToString().Trim();
            textBoxPrice.Text = dataGridViewService.CurrentRow.Cells["price"].Value.ToString().Trim();

            try
            {

                MemoryStream stream = new MemoryStream((byte[])dataGridViewService.CurrentRow.Cells["picture"].Value);
                Image RetImage = Image.FromStream(stream);
                pictureBoxService.Image = RetImage;
            }
            catch (Exception ex)
            {
                pictureBoxService.Image = null;
            }

        }
    }
}
