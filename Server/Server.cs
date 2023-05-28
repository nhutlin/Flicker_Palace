using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        private SqlConnection conn;
        private TcpListener tcpServer;
        private List<EndPoint> userList = new List<EndPoint>();
        private Packet receivedData;

        public Server()
        {
            conn = DBConnection.GetConnection();
            conn.Open();
        }

        public TcpListener TcpServer
        {
            get { return this.tcpServer; }
            set { this.tcpServer = value; }
        }

        public Packet ReceivedData
        {
            get { return this.receivedData; }
            set { this.receivedData = value; }
        }
        public void Receive(object obj)
        {
            TcpClient client = obj as TcpClient;
            while (client.Connected)
            {
                NetworkStream net_stream = client.GetStream();
                byte[] data = new byte[1024];
                int byte_count = net_stream.Read(data, 0, data.Length);
                if (byte_count == 0)
                {
                    break;
                }
                this.receivedData = new Packet(data);
                this.userList.Add(client.Client.RemoteEndPoint);
                
                net_stream.Flush();
                // Con bo sung sau
            }
        }
    }
}
