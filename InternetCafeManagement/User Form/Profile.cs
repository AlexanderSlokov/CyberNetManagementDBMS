using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Account_Form;
using InternetCafeManagement.Database;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.User_Form
{
    public partial class UCProfile : UserControl
    {
        public UCProfile()
        {
            InitializeComponent();
        }
        static UCProfile instance;

        string username, gender, fullname, email, phone;
        AccountDB account = new AccountDB();
        OrderDB orderDB = new OrderDB();

        public static UCProfile ucprofile { get => instance; set => instance = value; }

        private void formProfile_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            formPasswordUpdate fPassword = new formPasswordUpdate();
            fPassword.Show(this);
        }

      
        public void LoadData()
        {
            ucprofile = this;
            username = account.getUsername();
            fullname = account.getUserFullName();
            gender = account.GetUserGender();
            email = account.getUserEmail();
            phone = account.getUserPhone();
            textBoxUsername.Text = username;
            textBoxName.Text = fullname;
            textBoxEmail.Text = email;
            textBoxPhone.Text = phone;
            comboBoxGender.Text = gender;

            dataGridViewOrderList.DataSource = orderDB.GetDataTableAllOrdersOfUser(CurrentUser.Id);

            dataGridViewOrderList.RowTemplate.Height = 200;
            dataGridViewOrderList.RowHeadersVisible = false;
            dataGridViewOrderList.AllowUserToAddRows = false;

            //dataGridViewOrderList.Columns["service_id"].Width = 50;
            //dataGridViewOrderList.Columns[0].HeaderText = "Service ID";
            //dataGridViewOrderList.Columns[1].Width = 100;
            //dataGridViewOrderList.Columns[1].HeaderText = "Name";
            //dataGridViewOrderList.Columns[2].Width = 70;
            //dataGridViewOrderList.Columns[2].HeaderText = "Position";
            //dataGridViewOrderList.Columns[3].Width = 70;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            fullname = textBoxName.Text;
            gender = comboBoxGender.Text;
            email = textBoxEmail.Text;
            phone = textBoxPhone.Text;

            if (dataValidate())
            {
                account.updateUserData(CurrentUser.Id, fullname, gender, phone, email);
                MessageBox.Show("Information Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            LoadData();
        }

        public bool dataValidate()
        {
            username = textBoxUsername.Text;
            fullname = textBoxName.Text;
            email = textBoxEmail.Text;
            phone = textBoxPhone.Text;
            /*
            if (!DataValidate.usernameValidate(username))
            {
                MessageBox.Show("Re-Enter username with no spaces and more than 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/
            if (!DataValidate.fullnameValidate(fullname))
            {
                MessageBox.Show("Re-Enter fullname with no spaces and more than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!DataValidate.phoneValidate(phone))
            {
                MessageBox.Show("Re-Enter valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
