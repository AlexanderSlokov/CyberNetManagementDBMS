using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberGamingManagement.Account_Form;
using CyberGamingManagement.Utility;

namespace CyberGamingManagement.AdminForm
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }
        static AdminMainForm adminMainForm;
        CurrentPCGetter pCGetter = CurrentPCGetter.GetCurrentPCGetter();
        public static AdminMainForm GetAdminMainForm {
            get
            {
                if (adminMainForm == null)
                {
                    adminMainForm = new AdminMainForm();
                }
                return adminMainForm;
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

        

        public EmployeeManagementForm employeeManagementForm = new EmployeeManagementForm();
        public ComputerRoomManageForm computerRoomManageForm;
        

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadComputerRoomManage()
        {
            //this. computerRoomManageForm = ComputerRoomManageForm.GetComputerRoomManage;
            //computerRoomManageForm.Dock = DockStyle.Fill;
            //this.panelContainer.Controls.Add(computerRoomManageForm);
            //computerRoomManageForm.Show();
            //computerRoomManageForm.BringToFront();
        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        public void LoadData()
        {
            Dashboard schedule = new Dashboard();
            schedule.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(schedule);
            schedule.Show();
            schedule.BringToFront();

            Image logOutImage = Properties.Resources.logout;
            this.buttonLogOut.Image = (Image)(new Bitmap(logOutImage, new Size(20, 20)));
            Image computerRoomImage = Properties.Resources.computer;
            this.buttonComputerRoom.Image = (Image)(new Bitmap(computerRoomImage, new Size(30, 30)));
        }
        private void buttonEmployeeManage_Click(object sender, EventArgs e)
        {
            employeeManagementForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(employeeManagementForm);
            employeeManagementForm.Show();
            employeeManagementForm.BringToFront();
        }

        private void buttonComputerRoom_Click(object sender, EventArgs e)
        {
            ComputerRoomManagerForm computerRoomManagerForm = new ComputerRoomManagerForm();
            computerRoomManagerForm.Show(this);
            //LoadComputerRoomManage();
        }
        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard schedule = new Dashboard();
            schedule.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(schedule);
            schedule.Show();
            schedule.BringToFront();
        }

        private void buttonSchedule_Click_1(object sender, EventArgs e)
        {
            ShiftManagement shiftManagement = new ShiftManagement();
            shiftManagement.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(shiftManagement);
            shiftManagement.Show();
            shiftManagement.BringToFront();
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(service);
            service.Show();
            service.BringToFront();
        }

        private void buttonSalary_Click(object sender, EventArgs e)
        {
            SalaryUC salary = new SalaryUC();
            salary.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(salary);
            salary.Show();
            salary.BringToFront();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            CurrentUser.destroyUser();

            pCGetter.StopPC();
            formLogin login = new formLogin();
            login.Show();
            this.Close();
        }
    }
}
