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
using CyberGamingManagement.Database;

namespace CyberGamingManagement.AdminForm
{
    public partial class Service : UserControl
    {
        public Service()
        {
            InitializeComponent();
        }
        ServiceDB serviceDB = new ServiceDB();
        private void buttonNewService_Click(object sender, EventArgs e)
        {
            Add();
        }
        void Add()
        {
            int id;
            try
            {
                id = Int32.Parse(textBoxServiceID.Text.ToString());
            }
            catch
            {
                id = 0;
            }
            string name = textBoxServiceName.Text.ToString();
            string description = textBoxDescription.Text.ToString();
            float price = float.Parse(textBoxPrice.Text.ToString());
            Image picture = pictureBoxService.Image;
            if(serviceDB.isServiceExists(id) == false)
            {
                if(serviceDB.InsertService(id, name, description, price, picture)){
                    MessageBox.Show("Successfully Insert New Service", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                   
                }
                else
                {
                    MessageBox.Show("Failed To Insert New Service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void LoadData()
        {
            textBoxServiceID.ReadOnly = false; textBoxServiceName.ReadOnly = false; 
            textBoxServiceName.ReadOnly = false;

            dataGridViewService.DataSource = serviceDB.GetDataTableAllServices();
            dataGridViewService.RowTemplate.Height = 200;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            int id;
            try
            {
                id = Int32.Parse(textBoxServiceID.Text.ToString());
            }
            catch
            {
                id = 0;
            }
            serviceDB.DeleteService(id);
            MessageBox.Show("Successfully Delete Service with ID: " + id, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LoadData();

        }

        private void Service_Load(object sender, EventArgs e)
        {
            pictureBoxService.SizeMode = PictureBoxSizeMode.StretchImage;
            LoadData();
        }
        private void UploadImage()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxService.Image = Image.FromFile(opf.FileName);
            }
            else
            {
                pictureBoxService.Image = null;
            }
        }
        private void buttonUpdateInformation_Click(object sender, EventArgs e)
        {
            UploadImage();
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
