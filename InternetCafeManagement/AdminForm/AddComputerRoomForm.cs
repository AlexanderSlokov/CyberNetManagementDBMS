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
    public partial class AddComputerRoomForm : System.Windows.Forms.Form
    {
        public AddComputerRoomForm()
        {
            InitializeComponent();
        }
        ComputerRoomDB computerRoomDB = new ComputerRoomDB();
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int roomId, floor, max_comp_num;
            Int32.TryParse(textBoxRoomID.Text, out roomId);
            Int32.TryParse(textBoxFloor.Text, out floor);

            if(DataValidate.TextBoxNumInputCheck(textBoxMaxComputer.Text) == true)
            {
                max_comp_num = Int32.Parse(textBoxMaxComputer.Text);
                if (computerRoomDB.IsComputerRoomExistsByID(roomId) == false)
                {
                    if (AddRoom(roomId, floor, max_comp_num))
                    {
                        MessageBox.Show("Successfully Added New Room", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Adding New Room Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Room Exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Input maximum capacity greater than 0 or a valid number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AddRoom(int roomId, int floor, int max_comp_num)
        {
            return computerRoomDB.AddNewComputerRoom(roomId, floor, 0, Status.available, max_comp_num);   
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
