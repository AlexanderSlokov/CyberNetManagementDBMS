using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using InternetCafeManagement.SocketConnection;
namespace InternetCafeManagement.ServerReceivedObject
{
    [Serializable]
    internal class AccountSRO
    {
        private string username;
        private string password;
        private string action;
        private string status;
        public AccountSRO()
        {
        }
        public AccountSRO(string username, string password, string action, string status)
        {
            this.Username = username;
            this.Password = password;
            this.Action = action;
            this.Status = status;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Action { get => action; set => action = value; }
        public string Status { get => status; set => status = value; }
    }
}
