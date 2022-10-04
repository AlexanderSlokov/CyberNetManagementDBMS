using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberGamingManagement.Database;

namespace CyberGamingManagement.Model
{
    public class Computer
    {
        private int id;
        private string info;
        private int roomID;
        private string status;
        private float fee_per_hour;
        private string macAddress;

        private ComputerDB computerDB = new ComputerDB();
        public Computer()
        {

        }

        public Computer(int id)
        {
            this.id = id;
            this.info = computerDB.GetComputerInfo(this.id);
            this.roomID = computerDB.GetComputerRoomID(this.id);
            this.status = computerDB.GetComputerStatus(this.id);
            this.fee_per_hour = computerDB.GetComputerFeePerHour(this.id);
        }

        public int Id { get => id; set => id = value; }
        public string Info { get => info; set => info = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public string Status { get => status; set => status = value; }
        public float Fee_per_hour { get => fee_per_hour; set => fee_per_hour = value; }
        public string MacAddress { get => macAddress; set => macAddress = value; }
    }
}
