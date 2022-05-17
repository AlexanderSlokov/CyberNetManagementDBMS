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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        ShiftDB shiftDB = new ShiftDB();
        string current_week_date;
        private void dataGridViewSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            current_week_date = DateTime.Now.DayOfWeek.ToString();
            buttonToday.Text = current_week_date.ToString();

            dataGridViewSchedule.RowHeadersVisible = false;
            dataGridViewSchedule.AllowUserToAddRows = false;

            dataGridViewSchedule.DataSource = shiftDB.GetScheduleOfAllEmployees(current_week_date);
            dataGridViewSchedule.Columns["id"].Width = 50;
            dataGridViewSchedule.Columns["id"].HeaderText = "Employee ID";
            dataGridViewSchedule.Columns["id"].DisplayIndex = 0;

            dataGridViewSchedule.Columns["name"].Width = 100;
            dataGridViewSchedule.Columns["name"].HeaderText = "Employee name";
            dataGridViewSchedule.Columns["name"].DisplayIndex = 1;

            dataGridViewSchedule.Columns["roomID"].Width = 50;
            dataGridViewSchedule.Columns["roomID"].HeaderText = "Room ID";
            dataGridViewSchedule.Columns["roomID"].DisplayIndex = 2;

            dataGridViewSchedule.Columns["startTime"].Width = 150;
            dataGridViewSchedule.Columns["startTime"].HeaderText = "Starting time";
            dataGridViewSchedule.Columns["startTime"].DisplayIndex = 3;

            dataGridViewSchedule.Columns["endTime"].Width = 150;
            dataGridViewSchedule.Columns["endTime"].HeaderText = "Endinging time";
            dataGridViewSchedule.Columns["endTime"].DisplayIndex = 4;

            dataGridViewSchedule.Columns["shift_type"].Width = 100;
            dataGridViewSchedule.Columns["shift_type"].HeaderText = "Shift Type";
            dataGridViewSchedule.Columns["shift_type"].DisplayIndex = 5;

        }
    }
}
