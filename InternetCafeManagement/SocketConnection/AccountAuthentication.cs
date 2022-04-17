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
using InternetCafeManagement.Database;
using InternetCafeManagement.ServerReceivedObject;
using InternetCafeManagement.ServerSendingObject;
using InternetCafeManagement.SocketConnection;

namespace InternetCafeManagement.SocketConnection
{
    public class AccountAuthentication
    {
        AccountDB accountDB = new AccountDB();
        private IPEndPoint IP;
        private Socket server;
        private List<Socket> clientList;
        private List<SocketData> dataList;

        public List<SocketData> DataList { get => dataList; set => dataList = value; }
        public List<Socket> ClientList { get => clientList; set => clientList = value; }
        public AccountAuthentication()
        {
            
        }
        public void LoginAuthentication()
        {
            /*
            Thread loginAuthentication = new Thread(() => Login(server));
            loginAuthentication.IsBackground = true;
            loginAuthentication.Start();
            */
        }
        public void Login(Server server)
        {
            while (true)
            {
                server.Connect();
                AccountSRO accountSRO = new AccountSRO();
                AccountSSO accountSSO = new AccountSSO();

                List<SocketData> dataList = new List<SocketData>();
                foreach (SocketData item in dataList)
                {
                    AccountSRO receivedAccount = (AccountSRO)item.Data;
                    accountSSO = accountDB.GetAccountSSO(receivedAccount);
                    server.Send(item.Client, receivedAccount);
                    accountSSO = accountDB.GetAccountSSO(receivedAccount);
                    server.Send(item.Client, receivedAccount);
                    Console.WriteLine("Send Packed");
                }
            }          
        }
        
        /// <summary>
        /// kết nối tới server
        /// </summary>
        public void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.BeginAccept(new AsyncCallback(AcceptCallBack), null);
            try
            {
                server.Bind(IP);
            }
            catch
            {

            }
            Thread listen = new Thread(() =>
            {
                try
                {
                    // vòng lặp vô tận
                    while (true)
                    {
                        // kết nối với tất cả client

                        server.Listen(100);
                        Socket client = server.Accept();
                        if (client != null)
                        {
                            Console.WriteLine("Connected");
                        }
                        clientList.Add(client);

                        // liên tục nhận gói tin

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                // bắt lỗi khi có 1 người ngắt kết nối thì vẫn chạy bình thường
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
        /// nhận một gói tin của một client
        /// </summary>
        /// <param name="obj"></param>
        public void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    object meessage = Deserialize(data);
                    SocketData socketData = new SocketData(meessage, client);
                    dataList.Add(socketData);
                    Send(client, socketData);
                    server.Send
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        /// <summary>
        /// nhận tin và gửi lại cho tất cả các client khác
        /// </summary>
        /// 


        public void Receive_And_Send_All(Object obj)
        {
            Socket client = obj as Socket;

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    object meessage = Deserialize(data);

                    // truyền tin
                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(Serialize(meessage));
                        }
                    }

                }
            }
            catch
            {
                // khi một client bị mất kết nối, bỏ client đó khỏi danh sách
                clientList.Remove(client);
                client.Close();
            }
        }

        public void Close()
        {
            server.Close();
        }
        /// <summary>
        /// gửi tin
        /// </summary>
        public void Send(Socket client, object data)
        {
            foreach(SocketData item in dataList)
            {
                AccountSRO accountSRO = new AccountSRO();
                accountSRO = (AccountSRO)item.Data;

                if (client != null && item.Client == client && accountSRO.Action.Equals("login")){
                    client.Send(Serialize(data));
                    server.Send(Serialize)
                }             
            }
            
        }
        public byte[] Serialize(object obj)
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
        public object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        public bool isConnected()
        {
            return server.Connected;
        }
    }
}
}
