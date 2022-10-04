using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberGamingManagement.Database;

namespace CyberGamingManagement.AdminForm
{
    public partial class ComputerRoomManagerForm : System.Windows.Forms.Form
    {
        public ComputerRoomManagerForm()
        {
            InitializeComponent();
        }
        public int transit_room_id;
        ComputerRoomDB computerRoomDB = new ComputerRoomDB();

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            AddComputerRoomForm addComputerRoomForm = new AddComputerRoomForm();
            addComputerRoomForm.Show(this);
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(comboBoxComputerRoomId.Text);
                if (computerRoomDB.DeleteComputerRoom(id))
                {
                    MessageBox.Show("Successfully Delete Room", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Failed To Delete Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                LoadData();
            }
            catch
            {

            }
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(comboBoxComputerRoomId.Text);
                transit_room_id = id;
                ComputerRoomManageForm computerRoomManageForm = new ComputerRoomManageForm();
                computerRoomManageForm.Show(this);
            }
            catch
            {

            }
        }

        private void ComputerRoomManagerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            comboBoxComputerRoomId.DataSource = computerRoomDB.GetAllRooms();
            comboBoxComputerRoomId.DisplayMember = "id";
            comboBoxComputerRoomId.ValueMember = "id";
            if (Int32.Parse(computerRoomDB.RoomCount().ToString()) == 1 || Int32.Parse(computerRoomDB.RoomCount().ToString()) == 0)
            {
                labelRoomCount.Text = Int32.Parse(computerRoomDB.RoomCount().ToString()) + " room";
            }
            labelRoomCount.Text = Int32.Parse(computerRoomDB.RoomCount().ToString()) + " rooms";
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}