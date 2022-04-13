using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using InternetCafeManagement;

namespace InternetCafeManagement.ClientAccountForm
{
    public partial class formClientRegister : Form
    {

        public formClientRegister()
        {
            InitializeComponent();

        }
        string name, email, phone, username, password, passwordConfirm;
        DBConnection connection = new DBConnection();
        Account account = new Account();

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmPassword.PasswordChar = '•';
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxUsername.Focus();
        }

        private void formRegister_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorPasswordConfirm_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void labelBackToLogIn_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        bool verif(string input)
        {
            if ((input.Trim()) == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void register()
        {
            bool usernameCheck = false, passwordCheck = false;
            bool passwordTyped = false, passwordConfirmed = false;
            name = textBoxName.Text;
            email = textBoxEmail.Text;
            phone = textBoxPhone.Text;
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            passwordConfirm = textBoxConfirmPassword.Text;
            if (!verif(username))
            {
                labelErrorUsername.Visible = true;
                labelErrorUsername.Text = ("Please enter valid username");
                usernameCheck = false;
            }
            else
            {
                if (account.isUserExist_By_Username(username))
                {
                    labelErrorUsername.Text = ("Existed Username");
                    usernameCheck = false;
                }
                else
                {
                    usernameCheck = true;
                    labelErrorUsername.Text = string.Empty;
                }

            }
            if (password == "")
            {
                labelErrorPassword.Text = ("Please Enter Password");
                passwordCheck = false;
                passwordTyped = false;
            }
            else
            {
                labelErrorPassword.Text = string.Empty;
                passwordTyped = true;
            }

            if (passwordConfirm == "")
            {
                labelErrorPasswordConfirm.Visible = true;
                labelErrorPasswordConfirm.Text = ("Please Confirm Your Password");
                passwordCheck = false;
                passwordConfirmed = false;
            }
            else
            {
                labelErrorPasswordConfirm.Text = string.Empty;
                passwordConfirmed = true;
            }
            if (password == passwordConfirm && password.Length != 0 && passwordConfirm.Length != 0)
            {
                passwordCheck = true;

            }
            else
            {
                if (passwordTyped && passwordConfirmed)
                {
                    labelErrorPasswordConfirm.Visible = true;
                    labelErrorPasswordConfirm.Text = ("Passwords are not the same");
                    passwordCheck = false;
                }
            }
            if (passwordCheck == true && usernameCheck == true)
            {
                labelErrorPassword.Text = string.Empty;

                if(account.register(name, email, phone, username, password))
                {
                    MessageBox.Show("Successfuly Registed");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Fill All The Fields");
                }
                
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}

