using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Utility
{
    public class NhanVien
    {
        private string id;
        private string name;
        private string sex;
        private DateTime dateOfBirth;
        private string address;
        private string phoneNumber;

        public NhanVien() {}

        public NhanVien(string Id, string Name ,string Sex, DateTime DayOfBirth, string Address, string PhoneNumer)
        {
            id = Id;
            name = Name;
            sex = Sex;
            dateOfBirth = DayOfBirth;   
            address = Address;  
            phoneNumber = PhoneNumer;   

            
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
