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
        private static string name;
        private static float balance;
        private static string role;
        private static DateTime loginTime;
        private static DateTime lastLoginTime;

        private static bool isLoggedIn;
        private static string loginRequest;

        public static int Id { get => id; set => id = value; }
        public static string Role { get => role; set => role = value; }
        public static DateTime LoginTime { get => loginTime; set => loginTime = value; }
        public static DateTime LastLoginTime { get => lastLoginTime; set => lastLoginTime = value; }
        public static bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }
        public static string LoginRequest { get => loginRequest; set => loginRequest = value; }
        public static string Name { get => name; set => name = value; }
        public static float Balance { get => balance; set => balance = value; }
        public static void destroyUser()
        {
            Id = 0;
            Role = null;
            Balance = 0;
            LoginRequest = null;
            LoginTime = DateTime.MinValue;
            isLoggedIn = false;
            loginRequest = null;
        }
    }
}
