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
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.AdminForm
{
    public partial class ComputerDetailForm : System.Windows.Forms.Form
    {
        public ComputerDetailForm()
        {
            InitializeComponent();
        }
        ComputerRoomManageForm computerRoomManageForm;
        private int current_computer_id, current_room_id;
        ComputerDB computerDB = new ComputerDB();
        private void ComputerDetailForm_Load(object sender, EventArgs e)
        {
            LoadData();
            timerUsingTime.Start();
        }

        private void buttonUpdateInformation_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void UpdateData()
        {
            string info = textBoxInfo.Text;
            float fee = float.Parse(textBoxFee.Text);
            if(computerDB.UpdateInfo(current_computer_id, info) == false)
            {

            }
            if (DataValidate.TextBoxNumInputCheck(textBoxFee.Text))
            {
                fee = float.Parse(textBoxFee.Text);
                if (computerDB.UpdateFeePerHour(current_room_id, fee) == false)
                {
                    MessageBox.Show("Updating New Computer Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully Update Computer Information", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Input valid currency number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private void buttonServiceList_Click(object sender, EventArgs e)
        {

        }

        private void buttonMakeBusy_Click(object sender, EventArgs e)
        {
            if (computerDB.GetComputerStatus(current_computer_id) == Status.available)
            {
                computerDB.MakeBusy(current_computer_id);
                LoadData();
            }
            else if (computerDB.GetComputerStatus(current_computer_id) == Status.in_use)
            {
                computerDB.MakeBusy(current_computer_id);
                LoadData();
            }
            else if (computerDB.GetComputerStatus(current_computer_id) == Status.busy)
            {
                computerDB.MakeAvailable(current_computer_id);
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            computerDB.DeleteComputer(current_computer_id);
            this.Close();

        }

        private void ComputerDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            computerRoomManageForm = (ComputerRoomManageForm)(this.Owner);
            computerRoomManageForm.LoadData();
        }

        private void timerUsingTime_Tick(object sender, EventArgs e)
        {
            TimeSpan using_time = (DateTime.Now.Subtract(CurrentUser.LoginTime));

            labelUsingTime.Text = using_time.ToString(@"hh\:mm\:ss");

        }

        public void LoadData()
        {
            computerRoomManageForm = (ComputerRoomManageForm)(this.Owner);
            current_computer_id = computerRoomManageForm.transit_computer_id;
            current_room_id = computerRoomManageForm.current_room_id;
            labelComputerID.Text = "PC no: " + current_computer_id.ToString();
            labelRoomID.Text = "Room: " + current_room_id.ToString();
            textBoxInfo.Text = computerDB.GetComputerInfo(current_computer_id);
            textBoxFee.Text = (computerDB.GetComputerFeePerHour(current_computer_id)).ToString();
            labelLoginTime.Text = CurrentUser.LoginTime.ToString();

            if(computerDB.GetComputerStatus(current_computer_id) == Status.available)
            {
                Image bigImage = Properties.Resources.check;
                this.buttonDisplayStatus.Image = (Image)(new Bitmap(bigImage, new Size(20, 20)));
                buttonDisplayStatus.Text = "AVAILABLE";
                buttonDisplayStatus.BackColor = Color.FromArgb(192, 255, 192);
                buttonDisplayStatus.ForeColor = Color.Black;
                buttonChangeStatus.Text = "SHOW DOWN";
            }
            else
            if (computerDB.GetComputerStatus(current_computer_id) == Status.busy)
            {
                Image bigImage = Properties.Resources.red_x;
                this.buttonDisplayStatus.Image = (Image)(new Bitmap(bigImage, new Size(20, 20)));
                buttonDisplayStatus.Text = "Busy".ToUpper();
                buttonDisplayStatus.BackColor = Color.White;
                buttonDisplayStatus.ForeColor = Color.Red;
                buttonChangeStatus.Text = "TURN ON";
                buttonChangeStatus.ForeColor = Color.FromArgb(192, 255, 192);
            }
            else
            if (computerDB.GetComputerStatus(current_computer_id) == Status.in_use)
            {
                Image bigImage = Properties.Resources.gear;
                this.buttonDisplayStatus.Image = (Image)(new Bitmap(bigImage, new Size(20, 20)));
                buttonDisplayStatus.Text = "In Use".ToUpper();
                buttonDisplayStatus.BackColor = Color.FromArgb(192, 255, 192);
                buttonDisplayStatus.ForeColor = Color.Black;
                buttonChangeStatus.Text = "TURN ON";
                buttonChangeStatus.ForeColor = Color.FromArgb(192, 255, 192);
            }
        }
    }
}
