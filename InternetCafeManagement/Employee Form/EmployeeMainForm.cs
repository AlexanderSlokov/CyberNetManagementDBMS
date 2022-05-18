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
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.Employee_Form
{
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
        }
        static EmployeeMainForm thisInstance;
        public static EmployeeMainForm ThisInstance { get => thisInstance; set => thisInstance = value; }

        CurrentPCGetter pCGetter = CurrentPCGetter.GetCurrentPCGetter();

        

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            employeeDashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(employeeDashboard);
            employeeDashboard.Show();
            employeeDashboard.BringToFront();
        }

        void LoadData()
        {
            ThisInstance = this;

            Image computerRoomImage = Properties.Resources.computer;
            this.buttonComputerRoom.Image = (Image)(new Bitmap(computerRoomImage, new Size(30, 30)));

            Image logoutImage = Properties.Resources.logout;
            this.buttonLogOut.Image = (Image)(new Bitmap(logoutImage, new Size(20, 20)));
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            employeeDashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(employeeDashboard);
            employeeDashboard.Show();
            employeeDashboard.BringToFront();
        }
        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {

            CurrentUser.destroyUser();

            pCGetter.StopPC();
            formLogin login = new formLogin();
            login.Show();
            this.Close();
        }

        private void buttonComputerRoom_Click(object sender, EventArgs e)
        {
            ReLoadComputerManageUC();
        }
        public void ReLoadComputerManageUC()
        {
            ComputerRoomManageUC computerRoomManageForm = new ComputerRoomManageUC();
            computerRoomManageForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(computerRoomManageForm);
            computerRoomManageForm.Show();
            computerRoomManageForm.BringToFront();
        }
        private void buttonServiceManagement_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagement = new ServiceManagement();
            serviceManagement.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(serviceManagement);
            serviceManagement.Show();
            serviceManagement.BringToFront();
        }
    }
}
