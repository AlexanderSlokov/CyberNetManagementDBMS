using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberGamingManagement.Model
{
    public class Schedule
    {
        int employee_id;
        string employee_name;
        int roomID;
        TimeSpan startTime;
        TimeSpan endTime;
        DateTime date;
        DateTime check_in;
        string shift_type;
        string weekDate;

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public TimeSpan StartTime { get => startTime; set => startTime = value; }
        public TimeSpan EndTime { get => endTime; set => endTime = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Check_in { get => check_in; set => check_in = value; }
        public string Shift_type { get => shift_type; set => shift_type = value; }
        public string WeekDate { get => weekDate; set => weekDate = value; }
    }
}
