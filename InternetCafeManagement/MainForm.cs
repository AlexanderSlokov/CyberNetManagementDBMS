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
using InternetCafeManagement.AdminForm;

namespace InternetCafeManagement
{
    public partial class formMain : System.Windows.Forms.Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile fProfile = new Profile();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            ComputerRoomManageForm computerRoomManageForm = new ComputerRoomManageForm();
            computerRoomManageForm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComputerRoomManagerForm computerRoomManagerForm = new ComputerRoomManagerForm();
            computerRoomManagerForm.Show(this);
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm employeeManagementForm = new EmployeeManagementForm();
            employeeManagementForm.Show(this);  
        }

        private void buttonCheckList_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm employeeManagementForm = new EmployeeManagementForm();
            employeeManagementForm.Show(this);
        }
    }
}
