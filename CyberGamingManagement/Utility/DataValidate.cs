using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CyberGamingManagement.Database;

namespace CyberGamingManagement.Utility
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
        // trả về true nếu kiểm tra nếu input nhập vào một số nguyên dương lớn hơn không
        public static bool TextBoxNumInputCheck(string text)
        {
            try
            {
                int num = Int32.Parse(text);
                if(num <= 0)
                    return false;
                else
                    return true;
            }
            catch
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
            AccountDB account = new AccountDB();
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
            AccountDB account = new AccountDB();
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
            AccountDB account = new AccountDB();
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
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public static bool passwordValidate(string password)
        {
            AccountDB account = new AccountDB();
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
            AccountDB account = new AccountDB();
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
