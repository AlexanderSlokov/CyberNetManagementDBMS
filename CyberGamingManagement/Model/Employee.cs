using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberGamingManagement.Model
{
    public class Employee
    {
        private int id;
        private string name;
        private string position;
        private DateTime birthDate;
        private string gender;
        private string phoneNum;
        private string email;
        private Image image;
        private float salary_per_hour;
        private string username;
        private string password;
        private int age;
        public Employee()
        {
            DateTime now = DateTime.Today;
            this.age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age))
                this.age--;
        }
        public Employee(int id, string name, string position, DateTime birthDate, string gender, string phoneNum, string email, Image image, float salary_per_hour, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.birthDate = birthDate;
            this.gender = gender;
            this.phoneNum = phoneNum;
            this.email = email;
            this.image = image;
            this.salary_per_hour = salary_per_hour;
            this.username = username;
            this.password = password;

            DateTime now = DateTime.Today;
            this.age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age))
                this.age--;
        }
        public void SetAge()
        {
            DateTime now = DateTime.Today;
            this.age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age))
                this.age--;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public Image Image { get => image; set => image = value; }
        public float Salary_per_hour { get => salary_per_hour; set => salary_per_hour = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Age 
        { 
            get => age; 
        }
    }
}
