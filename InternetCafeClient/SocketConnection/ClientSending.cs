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
    public static class ClientSending
    {
        private static IPEndPoint IP;
        private static Socket client;

        /// <summary>
        /// kết nối tới server
        /// </summary>
        static void Connect()
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
                return;
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        /// <summary>
        /// nhận tin
        /// </summary>
        static void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string meessage = (string)Deserialize(data);
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
        static void Close()
        {
            client.Close();
        }
        /// <summary>
        /// phân mảnh data
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        static byte[] Serialize(object obj)
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
        static object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
    }
}