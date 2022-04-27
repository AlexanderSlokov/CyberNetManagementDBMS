using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Utility
{
    // A class storing the current user ID and his/her role
    static public class CurrentUser
    {
        private static int id;
        private static string role;
        private static DateTime loginTime;
        public static int Id { get => id; set => id = value; }
        public static string Role { get => role; set => role = value; }
        public static DateTime LoginTime { get => loginTime; set => loginTime = value; }
    }
}
