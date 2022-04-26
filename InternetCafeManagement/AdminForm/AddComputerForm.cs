using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Database;

namespace InternetCafeManagement.AdminForm
{
    public partial class AddNewComputerForm : Form
    {
        public AddNewComputerForm()
        {
            InitializeComponent();
        }

        ComputerDB computerDB = new ComputerDB();
        private void AddNewComputer()
        {
            //computerDB.AddNewComputer();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
