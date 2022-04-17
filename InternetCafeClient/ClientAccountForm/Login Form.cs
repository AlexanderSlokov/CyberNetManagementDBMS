using System;
using System.Windows.Forms;
using InternetCafeClient.ClientSendingObject;
using InternetCafeClient; 
namespace InternetCafeManagement.ClientAccountForm
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        AccountCSO accountCSO = new AccountCSO();  
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Focus();
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            /*formClientRegister formRegister = new formClientRegister();
            formRegister.Show(this);
            this.Hide();
            */
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
            accountCSO.Username = username;
            accountCSO.Password = password;
            accountCSO.Action = "login";
            accountCSO.login();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Select();
            textBoxUsername.Text = "admin1";
            textBoxPassword.Text = "12345";
        }
    }
}
