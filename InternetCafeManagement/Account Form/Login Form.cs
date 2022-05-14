using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using InternetCafeManagement.Database;
using InternetCafeManagement.Utility;
using InternetCafeManagement.Model;
using InternetCafeManagement.User_Form;

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
        ComputerDB computerDB = new ComputerDB();
        ComputerRoomDB computerRoomDB = new ComputerRoomDB();
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
                CurrentUser.LoginRequest = "user";
                if (accountDB.login(username, password))
                {

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Login Success");

                    MacAddressGetter macAddressGetter =  MacAddressGetter.getMacGetter();
                    string macAddress = macAddressGetter.GetMacAddress();
                    Computer loginComputer = computerDB.GetComputerByMacAddress(macAddress);
                    
                    if(loginComputer == null)
                    {
                        CurrentUser.LoginRequest = "manager";
                        CurrentPCGetter pcGetter = CurrentPCGetter.GetCurrentPCGetter();
                        if (computerRoomDB.IsComputerRoomExistsByID(1) == true)
                        {
                            if(computerDB.IsComputerExistsByMacAddess() == true)
                            {
                                computerDB.AddNewComputer(1, "", Status.available, 5000, macAddress);
                                loginComputer = new Computer();
                                loginComputer.Status = Status.available;
                                loginComputer.Fee_per_hour = 5000;
                                loginComputer.MacAddress = macAddress;
                                loginComputer.Id = computerDB.GetComputerByMacAddress(macAddress).Id;

                                pcGetter.SetCurrentComputer(loginComputer);
                                CurrentUser.LoginRequest = "user";
                            }
                            

                        }
                        else
                        {

                            computerRoomDB.AddNewComputerRoom(1, 1, 0, 30);

                            computerDB.AddNewComputer(1, "", Status.available, 5000, macAddress);

                            loginComputer.Status = Status.available;
                            loginComputer.Fee_per_hour = 5000;
                            loginComputer.MacAddress = macAddress;
                            loginComputer.Id = computerDB.GetComputerByMacAddress(macAddress).Id;

                            pcGetter.SetCurrentComputer(loginComputer);
                            CurrentUser.LoginRequest = "user";
                        }
                        
                    }
                    else if(loginComputer != null)
                    {
                        CurrentPCGetter pcGetter = CurrentPCGetter.GetCurrentPCGetter();
                        pcGetter.SetCurrentComputer(loginComputer);

                    }
                    
                    CurrentUser.Id = accountDB.getUserID(username);
                    CurrentUser.LoginTime = DateTime.Now;
                    CurrentUser.Role = "user";

                    UserUsingComputerDB userUsage = new UserUsingComputerDB();
                    userUsage.InsertUsage(loginComputer.Id, CurrentUser.Id, CurrentUser.LoginTime);

                    UserMainForm userMainForm = new UserMainForm();
                    userMainForm.Show(this);
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
                    CurrentUser.LoginRequest = "manager";
                    if (employeeDB.login(username, password))
                    {

                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Login Success");
                        Employee loginEmployee = employeeDB.GetEmployeeByUsername(username);
                        if(loginEmployee.Position == "employee")
                        {
                            CurrentUser.Id = loginEmployee.Id;
                            CurrentUser.LoginTime = DateTime.Now;
                            CurrentUser.Role = "employee";
                            formMain dashBoard = new formMain();
                            dashBoard.Show(this);
                            this.Hide();
                        }
                        else
                        {
                            if (loginEmployee.Position == "manager")
                            {
                                CurrentUser.Id = loginEmployee.Id;
                                CurrentUser.LoginTime = DateTime.Now;
                                CurrentUser.Role = "manager";
                                formMain dashBoard = new formMain();
                                dashBoard.Show(this);
                                this.Hide();
                            }
                                
                        }
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
