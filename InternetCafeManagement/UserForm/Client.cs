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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            textBoxStatus.Invoke((MethodInvoker)delegate ()
            {
                textBoxStatus.Text += e.MessageString;
            });
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(textBoxMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
