using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.AdminForm;
using InternetCafeManagement.Database;
using InternetCafeManagement.Model;
using InternetCafeManagement.Utility;

namespace InternetCafeManagement.Employee_Form
{
    public partial class ComputerRoomManageUC : System.Windows.Forms.UserControl
    {
        ComputerRoomDB computerRoom = new ComputerRoomDB();
        ComputerDB computerDB = new ComputerDB();
        public ComputerRoomManageUC()
        {
            InitializeComponent();
        }

        EmployeeMainForm employeeMainForm;
        static ComputerRoomManageUC thisInstance;
        public static ComputerRoomManageUC GetComputerRoomManageUC { get => thisInstance; set => thisInstance = value; }
        public int current_room_id;
        public int transit_computer_id;
        ShiftDB shiftDB = new ShiftDB();
        string weekDate = DateTime.Now.DayOfWeek.ToString();
        TimeSpan loginTime = CurrentUser.LoginTime.TimeOfDay;

        

        public void addAllButtons(int buttonNumber, List<Computer> computersList)
        {
            string buttonName = "button";
            int buttonID = 1;

            //init position
            int xpos = 1;
            int ypos = 1;
            int loopCount = 0;

            //status string

            for (int i = 0; i < buttonNumber; i++)
            {

                // properties
                Image buttonImage = Properties.Resources.in_use_computer;
                Button button = new Button();
                button.Width = 150;
                button.Height = 100;
                button.Name = buttonName + buttonID.ToString();

                button.TabStop = false;
                button.Image = buttonImage;
                string status = "Ready!!!";
                string dispayString = "COM " + buttonID + "\n" + status;
                button.Font = new System.Drawing.Font("Nirmala UI", 10F, FontStyle.Bold);
                if (status.Equals("Ready!!!"))
                {
                    button.ForeColor = Color.Green;
                }
                if (status.Equals("Busy"))
                {
                    button.ForeColor = Color.Red;
                }
                if (status.Equals("In Use"))
                {
                    button.ForeColor = Color.Blue;
                }
                button.Text = dispayString;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.TextAlign = ContentAlignment.MiddleRight;
                // events
                button.Click += new EventHandler(button_Click);
                button.Location = new Point(xpos, ypos);

                // Added
                panelComputerGrid.Controls.Add(button);

                // loop
                xpos += 150;
                loopCount++;
                buttonID++;
                if (loopCount == 5)
                {
                    loopCount = 0;
                    ypos += 100;
                    xpos = 1;
                }
            }
        }
        private void Button_Click(object sender, EventArgs e, int computer_id)
        {
            transit_computer_id = computer_id;
            Button button = (Button)sender;
            ComputerDetailForm computerDetailForm = new ComputerDetailForm();
            computerDetailForm.Show(this);

        }
        public void AddAllButtons(List<Computer> computersList)
        {
            string buttonName = "button";

            //init position
            int xpos = 1;
            int ypos = 1;
            int loopCount = 0;

            //loop
            foreach (Computer computer in computersList)
            {
                // properties
                Image buttonImage = Properties.Resources.in_use_computer;
                Button button = new Button();
                button.Width = 150;
                button.Height = 100;
                button.Name = buttonName + computer.Id.ToString();

                button.TabStop = false;
                button.Image = buttonImage;
                string status = computer.Status;
                string dispayString = "COM " + computer.Id + "\n" + status;
                button.Font = new System.Drawing.Font("Nirmala UI", 10F, FontStyle.Bold);
                if (status.Equals(Status.available))
                {
                    button.ForeColor = Color.Green;
                }
                if (status.Equals(Status.busy))
                {
                    button.ForeColor = Color.Red;
                }
                if (status.Equals(Status.in_use))
                {
                    button.ForeColor = Color.Blue;
                }
                button.Text = dispayString;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.TextAlign = ContentAlignment.MiddleRight;

                // events
                button.Click += (sender, EventArgs) => { Button_Click(sender, EventArgs, computer.Id); };
                button.Location = new Point(xpos, ypos);

                // Added
                panelComputerGrid.Controls.Add(button);

                // loop
                xpos += 150;
                loopCount++;

                if (loopCount == 5)
                {
                    loopCount = 0;
                    ypos += 100;
                    xpos = 1;
                }
            }
        }
        public void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ComputerDetailForm computerDetailForm = new ComputerDetailForm();
            computerDetailForm.ShowDialog(this);

        }
        private void ComputerRoomManageForm_Load(object sender, EventArgs e)
        {

            LoadData();
            FillGrid();
        }
        private void FillGrid()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = computerDB.GetDataTableAllComputerByRoomID(current_room_id);

            dataGridView1.Columns["id"].Width = 70;
            dataGridView1.Columns["id"].HeaderText = "Computer ID";
            dataGridView1.Columns["info"].Width = 100;
            dataGridView1.Columns["info"].HeaderText = "Description";
            dataGridView1.Columns["roomID"].Width = 70;
            dataGridView1.Columns["roomID"].HeaderText = "Room ID";
            dataGridView1.Columns["fee_per_hour"].Width = 70;
            dataGridView1.Columns["fee_per_hour"].HeaderText = "Fee(VND per hour)";
            dataGridView1.Columns["macAddress"].HeaderText = "Mac Address";
        }
        public void LoadData()
        {
            GetComputerRoomManageUC = this;

            Schedule currentSchedule = shiftDB.GetSchedulesOfEmployee(CurrentUser.Id, weekDate, loginTime);
            current_room_id = currentSchedule.RoomID;
            labelRoomID.Text = "Room 0" + current_room_id.ToString();
            labelComputerNumber.Text = "Computers Number: " + computerDB.ComputerCountByID(current_room_id).ToString();
            AddAllButtons(computerDB.GetAllComputersByRoomID(current_room_id));

            //try
            //{
            //    ComputerRoomManagerForm computerRoomManagerForm = (ComputerRoomManagerForm)(this.Owner);
            //    if (computerRoomManagerForm != null)
            //    {
            //        current_room_id = computerRoomManagerForm.transit_room_id;
            //        labelRoomID.Text = "Room 0" + current_room_id.ToString();
            //        labelComputerNumber.Text = "Computers Number: " + computerDB.ComputerCountByID(current_room_id).ToString();
            //        AddAllButtons(computerDB.GetAllComputersByRoomID(current_room_id));
            //    }
            //    else
            //    {
            //        labelRoomID.Text = "Room 0" + current_room_id.ToString();
            //        labelComputerNumber.Text = "Computers Number: " + computerDB.ComputerCountByID(current_room_id).ToString();
            //        AddAllButtons(computerDB.GetAllComputersByRoomID(current_room_id));
            //    }
            //}
            //catch
            //{
            //    labelRoomID.Text = "Room 0" + current_room_id.ToString();
            //    labelComputerNumber.Text = "Computers Number: " + computerDB.ComputerCountByID(current_room_id).ToString();
            //    AddAllButtons(computerDB.GetAllComputersByRoomID(current_room_id));
            //}

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AddNewComputerForm addNewComputerForm = new AddNewComputerForm();
            addNewComputerForm.ShowDialog(this);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            this.Refresh();
            employeeMainForm = EmployeeMainForm.ThisInstance;
            employeeMainForm.ReLoadComputerManageUC();
            LoadData();


            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            GetDataFromGridView(sender, e);
        }
        public void grid_click(object sender, EventArgs e, int computer_id)
        {
            transit_computer_id = computer_id;
            DataGridView dataGrid = (DataGridView)sender;
            ComputerDetailForm computerDetailForm = new ComputerDetailForm();
            computerDetailForm.Show(this);

        }
        public void GetDataFromGridView(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int id = (int)Int32.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                    grid_click(sender, e, id);
                }

            }
            catch (Exception ex)
            {
            }

        }
    }
}