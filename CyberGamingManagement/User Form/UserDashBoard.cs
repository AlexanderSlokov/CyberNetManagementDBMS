using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberGamingManagement.Database;
using CyberGamingManagement.Model;
using CyberGamingManagement.Utility;

namespace CyberGamingManagement.User_Form
{
    public partial class UserDashBoard : UserControl
    {
        public UserDashBoard()
        {
            InitializeComponent();
        }
        CurrentPCGetter pCGetter = CurrentPCGetter.GetCurrentPCGetter();
        Computer currentComputer;

        AccountDB accountDB = new AccountDB();
        private void buttonUpdateInformation_Click(object sender, EventArgs e)
        {

        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
            timerUsingTime.Start();
        }
        void LoadData()
        {
            try
            {
                currentComputer = pCGetter.GetCurrentComputer();

                textBoxUserFullName.Text = CurrentUser.Name;
                textBoxBalance.Text = CurrentUser.Balance.ToString();
                labelLoginTime.Text = CurrentUser.LoginTime.ToString();

                currentComputer = pCGetter.GetCurrentComputer();
                textBoxPcID.Text = currentComputer.Id.ToString();
                textBoxRoomID.Text = currentComputer.RoomID.ToString();
                try
                {
                    if (currentComputer.Info != null)
                        textBoxInfo.Text = currentComputer.Info.ToString();
                }
                catch (Exception ex)
                {
                    textBoxInfo.Text = String.Empty;
                }
                
                textBoxFee.Text = currentComputer.Fee_per_hour.ToString();
            }
            catch
            {

            }
        }

        private void timerUsingTime_Tick(object sender, EventArgs e)
        {
            CurrentUser.Balance = accountDB.GetUserBalance();
            TimeSpan using_time = (DateTime.Now.Subtract(CurrentUser.LoginTime));

            labelUsingTime.Text = using_time.ToString(@"hh\:mm\:ss");
            textBoxBalance.Text = CurrentUser.Balance.ToString();
        }

        private void textBoxUserFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
