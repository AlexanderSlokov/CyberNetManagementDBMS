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
using CyberGamingManagement.Utility;

namespace CyberGamingManagement.User_Form
{
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }
        RechargeDB rechargeDB = new RechargeDB();
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            float amount;
            try
            {
                amount = float.Parse(textBoxRecharge.Text);
            }
            catch
            {
                amount = 0;
            }
            if (rechargeDB.InsertRecharge(CurrentUser.Id, amount))
            {
                MessageBox.Show("Please wait for the confirmation!");
                this.Close();
            }
        }

        private void Recharge_Load(object sender, EventArgs e)
        {

        }
    }
}
