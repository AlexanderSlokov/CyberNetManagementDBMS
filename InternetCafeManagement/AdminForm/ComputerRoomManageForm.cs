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
    public partial class ComputerRoomManageForm : Form
    {
        ComputerRoomDB computerRoom = new ComputerRoomDB();   
        public ComputerRoomManageForm()
        {
            InitializeComponent();
        }
        public void addAllButtons(int buttonNumber)
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
        public void button_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            button.Text = button.Name;
        }
        private void ComputerRoomManageForm_Load(object sender, EventArgs e)
        {
            addAllButtons(30);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AddNewComputerForm addNewComputerForm = new AddNewComputerForm();
            addNewComputerForm.Show(this);
        }
    }
}
