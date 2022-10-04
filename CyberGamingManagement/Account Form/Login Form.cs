using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CyberGamingManagement.Database;
using CyberGamingManagement.Utility;
using CyberGamingManagement.Model;
using CyberGamingManagement.User_Form;
using CyberGamingManagement.AdminForm;
using CyberGamingManagement.Employee_Form;

namespace CyberGamingManagement.Account_Form
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
        UserUsingComputerDB userUsage = new UserUsingComputerDB();

        CurrentPCGetter pcGetter = CurrentPCGetter.GetCurrentPCGetter();
        MacAddressGetter macAddressGetter = MacAddressGetter.getMacGetter();
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
        void Login()
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;


            string macAddress = macAddressGetter.GetMacAddress();
            Computer loginComputer = computerDB.GetComputerByMacAddress(macAddress);
            pcGetter = CurrentPCGetter.GetCurrentPCGetter();

            if (radioButtonUser.Checked)
            {
                CurrentUser.LoginRequest = "user";
                if (accountDB.login(username, password))
                {

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Login Success");


                    if (loginComputer == null)
                    {
                        CurrentUser.LoginRequest = "manager";

                        if (computerRoomDB.IsComputerRoomExistsByID(1) == true)
                        {
                            if (computerDB.isComputerExistsByMacAddress(macAddress) == false)
                            {
                                computerDB.AddNewComputer(1, "", Status.available, 5000, macAddress);
                            }
                            loginComputer = new Computer();
                            loginComputer.Status = Status.available;
                            loginComputer.Fee_per_hour = 5000;
                            loginComputer.MacAddress = macAddress;
                            loginComputer.Id = computerDB.GetComputerByMacAddress(macAddress).Id;

                            pcGetter.SetCurrentComputer(loginComputer);
                            CurrentUser.LoginRequest = "user";
                        }
                        else
                        {
                            computerRoomDB.AddNewComputerRoom(1, 1, 0, 30);
                            if (computerDB.isComputerExistsByMacAddress(macAddress) == false)
                            {
                                computerDB.AddNewComputer(1, "", Status.available, 5000, macAddress);
                            }
                            loginComputer = new Computer();
                            loginComputer.Status = Status.available;
                            loginComputer.Fee_per_hour = 5000;
                            loginComputer.MacAddress = macAddress;
                            loginComputer.Id = computerDB.GetComputerByMacAddress(macAddress).Id;

                            pcGetter.SetCurrentComputer(loginComputer);
                            CurrentUser.LoginRequest = "user";
                        }

                    }
                    else if (loginComputer != null)
                    {

                        pcGetter.SetCurrentComputer(loginComputer);

                    }
                    //Set User va computer
                    CurrentUser.Id = accountDB.getUserID(username);
                    CurrentUser.LoginTime = DateTime.Now;
                    CurrentUser.Name = accountDB.getUserFullName();
                    CurrentUser.Balance = accountDB.GetUserBalance();

                    Computer currentComputer = pcGetter.GetCurrentComputer();

                    if (userUsage.isLogin(currentComputer.Id, CurrentUser.Id) == false)
                    {
                        userUsage.InsertUsage(loginComputer.Id, CurrentUser.Id, CurrentUser.LoginTime);
                    }
                    CurrentUser.Role = "user";

                    UserMainForm userMainForm = new UserMainForm();
                    userMainForm.Show(this);
                    this.Hide();

                    //CurrentUser.Role = "manager";
                    //AdminMainForm adminMainForm = new AdminMainForm();
                    //adminMainForm.Show(this);
                    //this.Hide();
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
                        //Set maytinh
                        if (loginComputer == null)
                        {
                            // Them phong va may tinh bang dia chi mac
                            CurrentUser.LoginRequest = "manager";

                            if (computerRoomDB.IsComputerRoomExistsByID(1) == true)
                            {
                                if (computerDB.isComputerExistsByMacAddress(macAddress) == false)
                                {
                                    computerDB.AddNewComputer(1, "", Status.available, 5000, macAddress);
                                }
                                loginComputer = new Computer();
                                loginComputer.Status = Status.available;
                                loginComputer.Fee_per_hour = 5000;
                                loginComputer.MacAddress = macAddress;
                                loginComputer.Id = computerDB.GetComputerByMacAddress(macAddress).Id;

                                pcGetter.SetCurrentComputer(loginComputer);
                                CurrentUser.LoginRequest = "user";
                            }
                            else
                            {
                                computerRoomDB.AddNewComputerRoom(1, 1, 0, 30);
                                if (computerDB.isComputerExistsByMacAddress(macAddress) == false)
                                {
                                    computerDB.AddNewComputer(1, "", Status.available, 5000, macAddress);
                                }
                                loginComputer = new Computer();
                                loginComputer.Status = Status.available;
                                loginComputer.Fee_per_hour = 5000;
                                loginComputer.MacAddress = macAddress;
                                loginComputer.Id = computerDB.GetComputerByMacAddress(macAddress).Id;

                                pcGetter.SetCurrentComputer(loginComputer);
                                CurrentUser.LoginRequest = "user";
                            }

                        }
                        else if (loginComputer != null)
                        {
                            pcGetter.SetCurrentComputer(loginComputer);

                        }

                        // Xet nguoi dung
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Login Success");


                        Employee loginEmployee = employeeDB.GetEmployeeByUsername(username);

                        // La employee
                        if (loginEmployee.Position == "employee")
                        {


                            // Set user and computer
                            CurrentUser.Id = loginEmployee.Id;
                            CurrentUser.Name = loginEmployee.Name;
                            CurrentUser.LoginTime = DateTime.Now;
                            CurrentUser.Role = "employee";
                            EmployeeMainForm employeeMainForm = new EmployeeMainForm();
                            employeeMainForm.Show(this);
                            this.Hide();
                        }
                        else
                        {
                            if (loginEmployee.Position == "manager")
                            {
                                CurrentUser.Id = loginEmployee.Id;
                                CurrentUser.Name = loginEmployee.Name;
                                CurrentUser.LoginTime = DateTime.Now;
                                CurrentUser.Role = "manager";
                                AdminMainForm adminMainForm = new AdminMainForm();
                                adminMainForm.Show(this);
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
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Select();
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void formLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }


        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}
