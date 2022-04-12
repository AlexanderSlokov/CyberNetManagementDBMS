using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace InternetCafeManagement.UserForm
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; // enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            textBoxStatus.Invoke((MethodInvoker)delegate ()
            {
                textBoxStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You said {0}", e.MessageString));
            });
        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            textBoxStatus.Text += "Server  started \n ";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBoxHost.Text);
            if(server.IsStarted == false)
            {
                server.Start(ip, Convert.ToInt32(textBoxPort.Text));
            }
           
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
