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
    public partial class AddComputerRoomForm : Form
    {
        public AddComputerRoomForm()
        {
            InitializeComponent();
        }
        ComputerRoomDB computerRoomDB = new ComputerRoomDB();
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int roomId, floor;
            Int32.TryParse(textBoxRoomID.Text, out roomId);
            Int32.TryParse(textBoxFloor.Text, out floor);

            if (computerRoomDB.IsComputerRoomExistsByID(roomId) == false)
            {
                if(AddRoom(roomId, floor))
                {
                    MessageBox.Show("Successfully Added New Room", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Adding New Room Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            else
            {
                MessageBox.Show("Room Exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AddRoom(int roomId, int floor)
        {
            return computerRoomDB.AddNewComputerRoom(roomId, floor, 0, "available");   
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
