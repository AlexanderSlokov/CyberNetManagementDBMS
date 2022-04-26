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

namespace InternetCafeManagement.AdminForm
{
    public partial class ComputerRoomManagerForm : Form
    {
        public ComputerRoomManagerForm()
        {
            InitializeComponent();
        }
        ComputerRoomDB computerRoomDB = new ComputerRoomDB();

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            AddComputerRoomForm addComputerRoomForm = new AddComputerRoomForm();
            addComputerRoomForm.Show(this);
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {

        }

        private void buttonManage_Click(object sender, EventArgs e)
        {

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
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
