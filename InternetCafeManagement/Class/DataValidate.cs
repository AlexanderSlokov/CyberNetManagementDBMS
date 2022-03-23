using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Class
{
    public static class DataValidate
    {
        // containSpace: hàm kiểm tra không có khoảng trắng, trả về true nếu không có khoảng trắng, trả về fasle nếu có khoảng trắng trong chuỗi.
        public static bool containSpace(string input)
        {
            if (input.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Hàm check chuỗi có phải là email hay không, trả về true nếu là email, trả về false nếu không phải là email.
        public static bool emailCheck(string email)
        {
            int number_of_at = 0; // số dấu '@'
            foreach(char c in email)
            {
                if (c ==  '@')
                {
                    number_of_at++;
                }
            }
            if (number_of_at == 1)
            {
                return true;
            }
            return false;
        }
        public static bool usernameValidate(string username)
        {
            Account account = new Account();
            if (username == String.Empty)
            {
                return false;
            }
            if(username.Length < 8)
            {
                return false;
            }
            if (containSpace(username))
            {
                return false;
            }
            return true;
        }
        public static bool phoneValidate(string phone)
        {
            Account account = new Account();
            if (phone == String.Empty)
            {
                return false;
            }
            if (phone.Length < 3 && phone.Length >15)
            {
                return false;
            }
            if (containSpace(phone))
            {
                return false;
            }
            return true;
        }
        public static bool fullnameValidate(string fullname)
        {
            Account account = new Account();
            if (fullname == String.Empty)
            {
                return false;
            }
            if (fullname.Length < 3)
            {
                return false;
            }
            return true;
        }
        public static bool emailValidate(string email)
        {
            Account account = new Account();
            if (email == String.Empty)
            {
                return false;
            }
            if (email.Length < 3)
            {
                return false;
            }
            if (!emailCheck(email))
            {
                return false;
            }
            if (containSpace(email))
            {
                return false;
            }
            return true;
        }
        public static bool passwordValidate(string password)
        {
            Account account = new Account();
            if (password == String.Empty)
            {
                return false;
            }
            /*
            if (password.Length < 8)
            {
                return false;
            }
            */
            if (containSpace(password))
            {
                return false;
            }
            return true;
        }
        public static bool doublePasswordValidate(string password1, string password2)
        {
            Account account = new Account();
            if (password1 != password2)
            {
                return false;
            }
            if (password1 == String.Empty)
            {
                return false;
            }
            /*
            if (password1.Length < 8)
            {
                return false;
            }
            */
            if (containSpace(password1))
            {
                return false;
            }
            if (password2 == String.Empty)
            {
                return false;
            }
            /*
            if (password2.Length < 8)
            {
                return false;
            }
            */
            if (containSpace(password2))
            {
                return false;
            }
            
            return true;
        }
    }
}
