using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeClient.SocketConnection
{
    public  class Client
    {
        private  IPEndPoint IP;
        private  Socket client;
        private object obj;

        public  object Obj { get => obj; set => obj = value; }

        /// <summary>
        /// kết nối tới server
        /// </summary>
        public  void Connect()
        {
            //IP địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        /// <summary>
        /// gửi tin
        /// </summary>
        public  void Send(object obj)
        {
            if(obj != null && client.Connected == true)
                client.Send(Serialize(obj));
        }

        /// <summary>
        /// nhận tin
        /// </summary>
        public void Receive()
        {

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    object message = (object)Deserialize(data);
                    this.obj = message;
                }
            }
            catch
            {
                Close();
            }
        }
        /// <summary>
        /// đóng kết nối hiện thời
        /// </summary>
        public  void Close()
        {
            client.Close();
        }
        /// <summary>
        /// phân mảnh data
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public  byte[] Serialize(object obj)
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
        public  object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
    }
}