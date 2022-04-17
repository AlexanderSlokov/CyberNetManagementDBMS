using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.SocketConnection
{
    public class SocketData
    {
        private object data;
        private Socket client;

        public SocketData()
        {

        }
        public SocketData(object data, Socket client)
        {
            this.data = data;
            this.client = client;
        }

        public object Data { get => data; set => data = value; }
        public Socket Client { get => client; set => client = value; }
    }
}
