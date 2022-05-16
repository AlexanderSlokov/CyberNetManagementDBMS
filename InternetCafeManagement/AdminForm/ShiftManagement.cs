using InternetCafeManagement.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeManagement.AdminForm
{
    public partial class ShiftManagement : UserControl
    {
        public ShiftManagement()
        {
            InitializeComponent();
        }
        ComputerRoomDB computerRoomDB = new ComputerRoomDB();
        ShiftDB shiftDB = new ShiftDB();
        private void buttonNewShift_Click(object sender, EventArgs e)
        {
            InsertShift();
            
        }
        public void InsertShift()
        {
            int id;
            try
            {
                id = Int32.Parse(textBoxShiftID.Text.ToString());
            }
            catch
            {
                id = 0;
            }
            string shiftType = comboBoxShiftType.Text;

            TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(labelEndTime.Text);
            string weekDate = comboBoxWeekDate.Text;

            if (shiftDB.isShiftExists(id) == false)
            {
                shiftDB.InsertShift(id, startTime, endTime, weekDate, shiftType);
            }
            else
            {
                MessageBox.Show("Exists Shift");
            }
        }
        private void buttonDeleteShift_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateShift_Click(object sender, EventArgs e)
        {

        }
        
        private void ShiftManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            comboBoxWeekDate.Text = "Monday";

            comboBoxRoomID.DataSource = computerRoomDB.GetAllRooms();
            comboBoxRoomID.DisplayMember = "id";
            comboBoxRoomID.ValueMember = "id";
        }

        private void comboBoxShiftType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shift_type = comboBoxShiftType.Text;
            if (shift_type == "Morning Shift")
            {
                labelStartTime.Text = "6:00:00";
                labelEndTime.Text = "12:00:00";
            }
            else if (shift_type == "Noon Shift")
            {
                labelStartTime.Text = "12:00:00";
                labelEndTime.Text = "18:00:00";
            }
            else if (shift_type == "Afternoon Shift")
            {
                labelStartTime.Text = "18:00:00";
                labelEndTime.Text = "23:00:00";
            }
            else
            {
                labelStartTime.Text = "23:00:00";
                labelEndTime.Text = "3:00:00";
            }
        }
    }
}
