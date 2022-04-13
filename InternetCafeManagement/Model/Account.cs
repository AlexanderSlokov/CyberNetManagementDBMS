using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Model
{
    public class Account
    {
        private string id;
        private string name;
        private string phone;
        private string email;
        private string username;
        private string password;
        private string role;

        public Account(string id, string name, string phone, string email, string username, string password, string role)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
        public Account(string name, string phone, string email, string username, string password, string role)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
