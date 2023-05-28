using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.TcpServer = new TcpListener(IPAddress.Any, 3000);
            server.TcpServer.Start();
            try
            {
                while (true)
                {
                    TcpClient client = server.TcpServer.AcceptTcpClient();
                    Thread receiveThread = new Thread(server.Receive)
                    {
                        IsBackground = true
                    };
                    receiveThread.Start(client);
                }
            }
            catch
            {
               
            }
        }
    }
}
