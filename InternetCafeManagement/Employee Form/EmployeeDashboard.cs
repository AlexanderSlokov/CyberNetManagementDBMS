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
using InternetCafeManagement.Model;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.Employee_Form
{
    public partial class EmployeeDashboard : UserControl
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }
        RechargeDB rechargeDB = new RechargeDB();
        AccountDB accountDB = new AccountDB();
        ShiftDB shiftDB = new ShiftDB();
        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        int roomID = 0;

        TimeSpan loginTime = CurrentUser.LoginTime.TimeOfDay;
        TimeSpan startTime, endTime;
        string weekDate = DateTime.Now.DayOfWeek.ToString();
        string shift_type;
        void LoadData()
        {
            Image checkImage = Properties.Resources.check;
            this.buttonCheckIn.Image = (Image)(new Bitmap(checkImage, new Size(20, 20)));

            dataGridViewRechargeRequest.RowHeadersVisible = false;
            dataGridViewRechargeRequest.AllowUserToAddRows = false;
            dataGridViewRechargeRequest.DataSource = rechargeDB.GetAllRechargeRequests();
            dataGridViewRechargeRequest.Columns[0].Width = 0;
            dataGridViewRechargeRequest.Columns[0].HeaderText = "ID";

            dataGridViewSchedule.RowHeadersVisible = false;
            dataGridViewSchedule.AllowUserToAddRows = false;
            dataGridViewSchedule.DataSource = shiftDB.GetDataTableSchedulesOfEmployee(weekDate, CurrentUser.Id);

            Schedule currentSchedule = shiftDB.GetSchedulesOfEmployee(CurrentUser.Id, weekDate, loginTime);
            if (loginTime >= currentSchedule.StartTime && loginTime <= currentSchedule.EndTime)
            {
                if (shiftDB.IsEmployeeCheckIn(CurrentUser.Id, currentSchedule.RoomID, currentSchedule.StartTime, currentSchedule.EndTime, currentSchedule.WeekDate) == true)
                {
                    buttonCheckIn.Enabled = true;
                    buttonCheckIn.Text = "Checked";
                }
                else
                {
                    buttonCheckIn.Enabled = false;
                }
                
                buttonCheckIn.Text = "CHECK IN";
                labelShiftAnnouncement.Text = "Shift Info";
                textBoxRoomID.Text = currentSchedule.RoomID.ToString();
                labelStartTime.Text = currentSchedule.StartTime.ToString();
                labelCheckOutTime.Text = currentSchedule.EndTime.ToString();
                textBoxShiftType.Text = currentSchedule.Shift_type.ToString();
            }
            else
            {
                buttonCheckIn.Enabled = false;
                buttonCheckIn.Text = "Not In Current Ship";
                labelShiftAnnouncement.Text = "You don't have any shift currently!";
                textBoxRoomID.Visible = false;
                labelStartTime.Visible = false;
                labelCheckOutTime.Visible = false;
                textBoxShiftType.Visible = false;
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            int roomID;
            try
            {
                roomID = Int32.Parse(textBoxRoomID.Text);
            }
            catch
            {
                roomID = 0;
            }
            TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(labelCheckOutTime.Text);
            DateTime check_in_date_time = DateTime.Now;

            
            shiftDB.MakeCheckInForEmployee(CurrentUser.Id, roomID, startTime, endTime, weekDate, check_in_date_time);
            buttonCheckIn.Text = "Checked";
            buttonCheckIn.Enabled = false;
        }

        private void dataGridViewRechargeRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int user_id;
            try
            {
                user_id = Int32.Parse(dataGridViewRechargeRequest.CurrentRow.Cells["ID"].Value.ToString());
            }
            catch
            {
                user_id = 0;
            }

            float amount;
            try
            {
                amount = float.Parse(dataGridViewRechargeRequest.CurrentRow.Cells["Amount"].Value.ToString());
            }
            catch
            {
                amount = 0;
            }
            int recharg_id;
            try
            {
                recharg_id = Int32.Parse(dataGridViewRechargeRequest.CurrentRow.Cells["Recharge ID"].Value.ToString());
            }
            catch
            {
                recharg_id = 0;
            }
            if (MessageBox.Show("Confirm Recharge At ID =" + user_id + " with amount = " + amount, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rechargeDB.DeleteRecharge(recharg_id);
                rechargeDB.RechargeForUser(user_id, amount);
                LoadData();
            }
            else
            {
                // user clicked no
            }
        }
    }
}
