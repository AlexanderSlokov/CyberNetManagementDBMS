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

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            userMainForm = this;
            UserDashBoard ucDashBoard = new UserDashBoard();
            ucDashBoard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucDashBoard);
            ucDashBoard.Show();
            ucDashBoard.BringToFront();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UCProfile ucProfile = new UCProfile();
            ucProfile.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucProfile);
            ucProfile.Show();
            ucProfile.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
