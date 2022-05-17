﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeManagement.AdminForm
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }
        static AdminMainForm adminMainForm;
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

        private void buttonShift_Click(object sender, EventArgs e)
        {
            ShiftManagement shiftManagement = new ShiftManagement();
            shiftManagement.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(shiftManagement);
            shiftManagement.Show();
            shiftManagement.BringToFront();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}