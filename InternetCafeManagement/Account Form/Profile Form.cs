﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Class;

namespace InternetCafeManagement.Account_Form
{
    public partial class formProfile : Form
    {
        public formProfile()
        {
            InitializeComponent();
        }

        string username, fullname, email, phone;
        Account account = new Account();
        private void formProfile_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            formPasswordUpdate fPassword = new formPasswordUpdate();
            fPassword.Show(this);
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData()
        {
            username = account.getUsername();
            fullname = account.getUserFullName();
            email = account.getUserEmail();
            phone = account.getUserPhone();
            textBoxUsername.Text = username;
            textBoxName.Text = fullname;
            textBoxEmail.Text = email;
            textBoxPhone.Text = phone;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (dataValidate())
            {
                account.updateUserData(CurrentUser.Id, fullname, email, phone);
                loadData();
                MessageBox.Show("Information Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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
            if (!DataValidate.emailValidate(email))
            {
                MessageBox.Show("Re-Enter a valid email with no spaces and contain '@'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
