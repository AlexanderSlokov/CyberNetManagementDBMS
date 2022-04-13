using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Database;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.Account_Form
{
    public partial class formPasswordUpdate : Form
    {
        public formPasswordUpdate()
        {
            InitializeComponent();
        }
        string oldPass, newPass, confirmPass;
        AccountDB account = new AccountDB();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            changePassword();
            textBoxOldPassword.Text = String.Empty;
            textBoxNewPassword.Text = String.Empty;
            textBoxConfirmPassword.Text = String.Empty;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxOldPassword.PasswordChar = '\0';
                textBoxNewPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxOldPassword.PasswordChar = '•';
                textBoxNewPassword.PasswordChar = '•';
                textBoxConfirmPassword.PasswordChar = '•';
            }
        }

        private void changePassword()
        {
            if (passwordCheck())
            {
                account.updatePassword(CurrentUser.Id, newPass);
                MessageBox.Show("Password Changed", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private bool passwordCheck()
        {
            oldPass = textBoxOldPassword.Text;
            newPass = textBoxNewPassword.Text;
            confirmPass = textBoxConfirmPassword.Text;
            if(!account.passwordCheck(CurrentUser.Id, oldPass))
            {
                MessageBox.Show("You entered wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!DataValidate.doublePasswordValidate(newPass, confirmPass))
            {
                MessageBox.Show("Two passwords are not the same or invalid lenght", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
