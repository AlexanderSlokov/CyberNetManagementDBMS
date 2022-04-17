using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeClient.ClientReceivedObject
{
    [Serializable]
    public class AccountCRO
    {
        private int id;
        private string name;
        private string gender;
        private string phone;
        private string balance;
        private string email;
        private string username;
        private string password;
        private string role;

        public AccountCRO()
        {

        }
        public AccountCRO(int id, string name, string gender, string phone, string balance, string email, string username, string password, string role)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Phone = phone;
            this.Balance = balance;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Balance { get => balance; set => balance = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

    }
}
