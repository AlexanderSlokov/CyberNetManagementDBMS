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
using InternetCafeManagement.AdminForm;
using InternetCafeManagement.Database;
using InternetCafeManagement.Model;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.User_Form
{
    public partial class UserMainForm : Form
    {
        static UserMainForm userMainForm;
        public static UserMainForm GetUserMainForm
        {
            get
            {
                if(userMainForm == null)
                {
                    userMainForm = new UserMainForm();
                }    
                return userMainForm;
            }
        }
        public Panel PanelContainer
        {
            get
            {
                return panelContainer;
            }
            set
            {
                panelContainer = value;
            }
        }

        public UserMainForm()
        {
            InitializeComponent();
        }

        bool LogOut;

        UCProfile ucProfile = new UCProfile();
        UserDashBoard ucDashBoard = new UserDashBoard();

        UserUsingComputerDB userUsingDB = new UserUsingComputerDB();
        AccountDB accountDB = new AccountDB();

        CurrentPCGetter pcGetter = CurrentPCGetter.GetCurrentPCGetter();
        Computer currentComputer;

        TimeSpan using_time;
        private void UserMainForm_Load(object sender, EventArgs e)
        {
            if(CurrentUser.Balance > 0)
            {
                LogOut = false;
                currentComputer = pcGetter.GetCurrentComputer();

                userMainForm = this;
                Image logoutImage = Properties.Resources.logout;
                this.buttonLogOut.Image = (Image)(new Bitmap(logoutImage, new Size(20, 20)));

                UserDashBoard ucDashBoard = new UserDashBoard();
                ucDashBoard.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(ucDashBoard);
                ucDashBoard.Show();
                ucDashBoard.BringToFront();

                timerUsingTime.Start();
                timerHour.Start();
            }
            else
            {
                LogOut = true;
                CurrentUser.Balance = 0;
                accountDB.MakeBalanceZero(CurrentUser.Id);

                MessageBox.Show("Your Balance Is 0, now log out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formLogin formLogin = new formLogin();
                formLogin.Show();
                this.Close();
            }
            
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UCProfile ucprofile = new UCProfile();
            ucProfile.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucProfile);
            ucProfile.LoadData();
            ucProfile.Show();
            ucProfile.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ucDashBoard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucDashBoard);
            ucDashBoard.Show();
            ucDashBoard.BringToFront();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut = true;
            Discharge();
            userUsingDB.DeleteUsage(currentComputer.Id);
            timerUsingTime.Stop();
            timerHour.Stop();

            CurrentUser.destroyUser();

            pcGetter.StopPC();
            formLogin formLogin = new formLogin();
            formLogin.Show();
            this.Close();
        }
        public void Discharge()
        {
            if (using_time.TotalMinutes < 20)
            {
                float amount = (currentComputer.Fee_per_hour / (float)3);
                accountDB.DischargeBalance(CurrentUser.Id, amount);
            }
            else if (using_time.TotalMinutes > 20 && using_time.TotalMinutes < 40)
            {
                float amount = (currentComputer.Fee_per_hour / (float) 2);
                accountDB.DischargeBalance(CurrentUser.Id, amount);
            }
            else if (using_time.TotalMinutes > 40 && using_time.TotalMinutes < 60)
            {
                float amount = currentComputer.Fee_per_hour;
                accountDB.DischargeBalance(CurrentUser.Id, amount);
            }

            if(CurrentUser.Balance <= 0)
            {
                CurrentUser.Balance = 0;
                accountDB.MakeBalanceZero(CurrentUser.Id);
            }
        }
        private void timerUsingTime_Tick(object sender, EventArgs e)
        {
            CurrentUser.Balance = accountDB.GetUserBalance();
            using_time = (DateTime.Now.Subtract(CurrentUser.LoginTime));
            if (CurrentUser.Balance <= 0)
            {
                timerUsingTime.Stop();
                LogOut = true;
                CurrentUser.Balance = 0;
                accountDB.MakeBalanceZero(CurrentUser.Id);

                MessageBox.Show("Your Balance Is 0, now log out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formLogin formLogin = new formLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerHour_Tick(object sender, EventArgs e)
        {
            CurrentUser.Balance = accountDB.GetUserBalance();
            float amount = currentComputer.Fee_per_hour;
            accountDB.DischargeBalance(CurrentUser.Id, amount);
            if (CurrentUser.Balance <= 0)
            {
                LogOut = true;
                CurrentUser.Balance = 0;
                accountDB.MakeBalanceZero(CurrentUser.Id);

                MessageBox.Show("Your Balance Is 0, now log out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formLogin formLogin = new formLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void UserMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(LogOut == false)
            {
                LogOut = true;
                Discharge();
                userUsingDB.DeleteUsage(currentComputer.Id);
                timerUsingTime.Stop();
                timerHour.Stop();

                formLogin formLogin = new formLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recharge recharge = new Recharge();
            recharge.ShowDialog(this);
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            
            UserService userService = new UserService();
            userService.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userService);
            userService.Show();
            userService.BringToFront();
        }
    }
}
