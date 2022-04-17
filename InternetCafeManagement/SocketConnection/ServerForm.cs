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

namespace InternetCafeManagement.TesingForm
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        /// <summary>
        /// kết nối tới server
        /// </summary>
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }                 
            });
            listen.IsBackground = true;
            listen.Start();
        }
        /// <summary>
        /// đóng kết nối hiện thời
        /// </summary>
        void Close()
        {
            server.Close();
        }
        /// <summary>
        /// gửi tin
        /// </summary>
        void Send(Socket client)
        {
            if (client != null && textBoxMessage.Text != string.Empty)
                client.Send(Serialize(textBoxMessage.Text));
        }
        /// <summary>
        /// nhận tin
        /// </summary>
        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string meessage = (string)Deserialize(data);

                    foreach (Socket item in clientList)
                    {
                        if(item != null && item != client)
                        {
                            item.Send(Serialize(meessage));
                        }
                    }
                    AddMessage(meessage);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }

        }

        void AddMessage(string s)
        {
            listView.Items.Add(new ListViewItem() { Text = s });
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
        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// gửi tin cho tất cả client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send(item);
            }
            AddMessage(textBoxMessage.Text);
            textBoxMessage.Clear();
        }
    }
}
