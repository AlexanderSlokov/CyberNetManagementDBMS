using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeManagement.UserForm
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint IP;
        Socket client;
        
        /// <summary>
        /// gửi tin đi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(textBoxMessage.Text);
        }
        /// <summary>
        /// kết nối tới server
        /// </summary>
        void Connect()
        {   
            //IP địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse("192.168.1.14"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        /// <summary>
        /// đóng kết nối hiện thời
        /// </summary>
        void Close()
        {
            client.Close();
        }
        /// <summary>
        /// gửi tin
        /// </summary>
        void Send()
        {
            if(textBoxMessage.Text != string.Empty)
                client.Send(Serialize(textBoxMessage.Text));
        }
        /// <summary>
        /// nhận tin
        /// </summary>
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string meessage = (string)Deserialize(data);

                    AddMessage(meessage);
                }
            }
            catch
            {
                Close();
            }
          
        }

        void AddMessage(string s)
        {
            listView.Items.Add(new ListViewItem() { Text = s });
            textBoxMessage.Clear();
        }
        /// <summary>
        /// phân mảnh data
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        /// <summary>
        /// gôm mảnh lại
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        /// <summary>
        /// đóng kết nối khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
