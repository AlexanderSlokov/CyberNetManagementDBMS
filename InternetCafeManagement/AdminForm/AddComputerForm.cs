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
using InternetCafeManagement.Utility;
namespace InternetCafeManagement.AdminForm
{
    public partial class AddNewComputerForm : Form
    {
        public AddNewComputerForm()
        {
            InitializeComponent();
        }
        public int current_room_id;
        ComputerDB computerDB = new ComputerDB();
        ComputerRoomDB computerRoomDB = new ComputerRoomDB();
        ComputerRoomManageForm computerRoomManageForm;
        private void AddNewComputer()
        {
            string info = textBoxInfo.Text;
            int room_id = current_room_id;
            if (computerDB.AddNewComputer(room_id, info, Status.available, 0))
            {
                MessageBox.Show("Successfully Added New Computer", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Adding New Computer Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BulkAddNewComputer(int num)
        {
            string info = textBoxInfo.Text;
            int room_id = current_room_id;
            for(int i = 0; i < num; i++)
            {
                computerDB.AddNewComputer(room_id, info, Status.available, 0);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxBulkAdd.Text != String.Empty)
            {
                int bulk_add_num = Int32.Parse(comboBoxBulkAdd.Text);
                BulkAddNewComputer(bulk_add_num);
            }
            else
                AddNewComputer();

            
            this.Close();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewComputerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            computerRoomManageForm = (ComputerRoomManageForm)(this.Owner);
            current_room_id = computerRoomManageForm.current_room_id;
            comboBoxRoomID.Text = current_room_id.ToString();
            textBoxInfo.Text = "Intel i7 \n RAM: 4GB \n GTX - 1080Ti";
            int capacity = computerRoomDB.GetMaxComputerCapacity(current_room_id) - computerRoomDB.GetComputerCount(current_room_id);
            for (int i = 1; i <= capacity; i++)
            {
                comboBoxBulkAdd.Items.Add(i.ToString());
            }
        }

        private void AddNewComputerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            computerRoomManageForm.LoadData();
        }
    }
}
