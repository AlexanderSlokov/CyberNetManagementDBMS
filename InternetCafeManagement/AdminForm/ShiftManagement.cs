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
        EmployeeDB employeeDB = new EmployeeDB();
        ShiftDB shiftDB = new ShiftDB();

        int insert_employee_id, insert_room_id;
        string insert_weekDate, insert_shiftType, insert_startTime, insert_endTime;
        private void buttonNewShift_Click(object sender, EventArgs e)
        {
            InsertShift();

        }
        public void InsertShift()
        {
            int roomID;
            try
            {
                roomID = Int32.Parse(comboBoxRoom.Text.ToString());
            }
            catch
            {
                roomID = 0;
            }

            int employeeID;
            try
            {
                employeeID = Int32.Parse(comboBoxEmployee.SelectedValue.ToString());
            }
            catch
            {
                employeeID = 0;
            }

            string shiftType = comboBoxShiftType.Text;

            TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(labelEndTime.Text);
            string weekDate = comboBoxWeekDate.Text;

            if (shiftDB.isShiftExists(employeeID, roomID, startTime, endTime, weekDate) == false)
            {
                if (shiftDB.InsertShift(employeeID, roomID, startTime, endTime, weekDate, shiftType))
                {
                    MessageBox.Show("Successfully Added New Shift", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed To Added New Shift", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exists Shift");
            }
        }
        private void buttonDeleteShift_Click(object sender, EventArgs e)
        {
            int roomID;
            try
            {
                roomID = Int32.Parse(comboBoxRoom.Text.ToString());
            }
            catch
            {
                roomID = 0;
            }

            int employeeID;
            try
            {
                employeeID = Int32.Parse(comboBoxEmployee.SelectedValue.ToString());
            }
            catch
            {
                employeeID = 0;
            }

            string shiftType = comboBoxShiftType.Text;

            TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(labelEndTime.Text);
            string weekDate = comboBoxWeekDate.Text;
            if (shiftDB.DeleteShift(employeeID, roomID, startTime, endTime, weekDate))
            {
                MessageBox.Show("Successfully Delete New Shift", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed To Delete New Shift", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateShift_Click(object sender, EventArgs e)
        {
            if (insert_employee_id == 0 ||
            insert_room_id == 0 ||
            insert_startTime == null ||
            insert_endTime == null ||
            insert_weekDate == null)
            {
                MessageBox.Show("Please click to choose");
            } else
            {
                int roomID;
                try
                {
                    roomID = Int32.Parse(comboBoxRoom.Text.ToString());
                }
                catch
                {
                    roomID = 0;
                }
                int employeeID;
                try
                {
                    employeeID = Int32.Parse(comboBoxEmployee.SelectedValue.ToString());
                }
                catch
                {
                    employeeID = 0;
                }

                string shiftType = comboBoxShiftType.Text;

                TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
                TimeSpan endTime = TimeSpan.Parse(labelEndTime.Text);
                string weekDate = comboBoxWeekDate.Text;
                if (shiftDB.UpdateShift(employeeID, roomID, startTime, endTime, weekDate, shiftType))
                {
                    MessageBox.Show("Successfully Update New Shift", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                }
                else
                {
                    shiftDB.DeleteShift(insert_employee_id, insert_room_id, TimeSpan.Parse(insert_startTime), TimeSpan.Parse(insert_endTime), insert_weekDate);


                    shiftDB.InsertShift(employeeID, roomID, startTime, endTime, weekDate, shiftType);
                    LoadData();
                    insert_employee_id = 0;
                    insert_room_id = 0;
                    insert_startTime = null;
                    insert_endTime = null;
                    insert_weekDate = null;
                }
            }
           
        }
        
        private void ShiftManagement_Load(object sender, EventArgs e)
        {
            comboBoxWeekDate.Text = "Monday";
            comboBoxShiftType.Text = "Morning Shift";
            LoadData();
        }
        void LoadData()
        {

            dataGridViewShift.DataSource = shiftDB.GetDataTableAllSchedules();

            dataGridViewShift.RowHeadersVisible = false;
            dataGridViewShift.AllowUserToAddRows = false;

            dataGridViewShift.Columns["id"].Width = 50;
            dataGridViewShift.Columns["id"].HeaderText = "Employee ID";
            dataGridViewShift.Columns["id"].DisplayIndex = 0;

            dataGridViewShift.Columns["name"].Width = 100;
            dataGridViewShift.Columns["name"].HeaderText = "Employee name";
            dataGridViewShift.Columns["name"].DisplayIndex = 1;

            dataGridViewShift.Columns["position"].Width = 100;
            dataGridViewShift.Columns["position"].HeaderText = "Employee position";
            dataGridViewShift.Columns["position"].DisplayIndex = 2;

            dataGridViewShift.Columns["roomID"].Width = 50;
            dataGridViewShift.Columns["roomID"].HeaderText = "Room ID";
            dataGridViewShift.Columns["roomID"].DisplayIndex = 3;

            dataGridViewShift.Columns["startTime"].Width = 100;
            dataGridViewShift.Columns["startTime"].HeaderText = "Starting time";
            dataGridViewShift.Columns["startTime"].DisplayIndex = 4;

            dataGridViewShift.Columns["endTime"].Width = 100;
            dataGridViewShift.Columns["endTime"].HeaderText = "Ending time";
            dataGridViewShift.Columns["endTime"].DisplayIndex = 5;

            dataGridViewShift.Columns["weekDate"].Width = 100;
            dataGridViewShift.Columns["weekDate"].HeaderText = "Week day";
            dataGridViewShift.Columns["weekDate"].DisplayIndex = 6;

            dataGridViewShift.Columns["shift_type"].Width = 100;
            dataGridViewShift.Columns["shift_type"].HeaderText = "Shift Type";
            dataGridViewShift.Columns["shift_type"].DisplayIndex = 7;

            //dataGridViewShift.Columns["date"].Width = 100;
            //dataGridViewShift.Columns["date"].HeaderText = "Check In Date";
            //dataGridViewShift.Columns["date"].DisplayIndex = 6;

            //dataGridViewShift.Columns["check_in"].Width = 100;
            //dataGridViewShift.Columns["check_in"].HeaderText = "Check In Date";
            //dataGridViewShift.Columns["check_in"].DisplayIndex = 6;
            //dataGridViewShift.Columns["check_in"].Visible = false;

            dataGridViewShift.Sort(dataGridViewShift.Columns[0], ListSortDirection.Ascending);

            //

            comboBoxRoom.DataSource = computerRoomDB.GetAllRooms();
            comboBoxRoom.DisplayMember = "id";

            //

            comboBoxEmployee.DataSource = employeeDB.GetEmployeesDataTable();
            comboBoxEmployee.DisplayMember = "name";
            comboBoxEmployee.ValueMember = "id";

            
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


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAutoAssign_Click(object sender, EventArgs e)
        {

        }
        
        private void dataGridViewShift_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewShift.CurrentRow != null)
                {
                    comboBoxEmployee.SelectedValue = dataGridViewShift.CurrentRow.Cells["id"].Value.ToString();
                    comboBoxRoom.Text = dataGridViewShift.CurrentRow.Cells["roomID"].Value.ToString();
                    comboBoxWeekDate.Text = dataGridViewShift.CurrentRow.Cells["weekDate"].Value.ToString();
                    comboBoxShiftType.Text = dataGridViewShift.CurrentRow.Cells["shift_type"].Value.ToString();
                    labelStartTime.Text = dataGridViewShift.CurrentRow.Cells["startTime"].Value.ToString();
                    labelEndTime.Text = dataGridViewShift.CurrentRow.Cells["endTime"].Value.ToString();

                    insert_employee_id = Int32.Parse(dataGridViewShift.CurrentRow.Cells["id"].Value.ToString());
                    insert_room_id = Int32.Parse(dataGridViewShift.CurrentRow.Cells["roomID"].Value.ToString());
                    insert_weekDate = dataGridViewShift.CurrentRow.Cells["weekDate"].Value.ToString();
                    insert_shiftType = dataGridViewShift.CurrentRow.Cells["shift_type"].Value.ToString();
                    insert_startTime = dataGridViewShift.CurrentRow.Cells["startTime"].Value.ToString();
                    insert_endTime = dataGridViewShift.CurrentRow.Cells["endTime"].Value.ToString();
                }
            }
            catch
            {

            }
        }
    }
}
