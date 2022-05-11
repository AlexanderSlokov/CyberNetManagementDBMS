using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using InternetCafeManagement.Database;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.Account_Form
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        AccountDB accountDB = new AccountDB();
        EmployeeDB employeeDB = new EmployeeDB();
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Focus();
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            formRegister formRegister = new formRegister();
            formRegister.Show(this);
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';

            }
            else
            {
                textBoxPassword.PasswordChar = '•';

            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (radioButtonUser.Checked)
            {
                CurrentUser.LoginRequest = "employee";
                if (accountDB.login(username, password))
                {

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Login Success");
                    CurrentUser.Id = accountDB.getUserID(username);
                    CurrentUser.LoginTime = DateTime.Now;
                    CurrentUser.Role = "manager";
                    formMain dashBoard = new formMain();
                    dashBoard.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (radioButtonEmployee.Checked)
                {
                    CurrentUser.LoginRequest = "employee";
                    if (accountDB.login(username, password))
                    {

                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Login Success");
                        CurrentUser.Id = accountDB.getUserID(username);
                        CurrentUser.LoginTime = DateTime.Now;
                        formMain dashBoard = new formMain();
                        dashBoard.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                   
            }
           
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Select();
            textBoxUsername.Text = "admin";
            textBoxPassword.Text = "12345";
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
