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
using InternetCafeManagement.UserForm;
namespace InternetCafeManagement
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            formProfile fProfile = new formProfile();
            fProfile.Show(this);
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            ComputerRoomManageForm computerRoomManageForm = new ComputerRoomManageForm();
            computerRoomManageForm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerForm server = new ServerForm();
            server.Show(this);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show(this);
        }
    }
}
