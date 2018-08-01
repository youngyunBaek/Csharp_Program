using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Lib;

namespace Socket_Server
{
    class MainApp
    {
        static void Main(string[] args)
        {
            const int bindPort = 5425;
            TcpListener server = null;
            try
            {
                IPEndPoint localAddress =
                    new IPEndPoint(0, bindPort);

                server = new TcpListener(localAddress);
                server.Start();

                Console.WriteLine("서버 시작.. ");

                while(true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("클라이언트 접속: {0} ",
                        ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    NetworkStream stream = client.GetStream();

                    Message reqMsg = MessageUtil.Receive(stream);

                    if(reqMsg.Header.Packet_Type != CONSTANS.A)
                    {
                        stream.Close();
                        client.Close();
                        continue;
                    }

                    Console.WriteLine("Packet Type      : ", reqMsg.Header.Packet_Type);
                    Console.WriteLine("Current Sequence : ", reqMsg.Header.Current_Sequence);
                    Console.WriteLine("Payload Size     : ", reqMsg.Header.Payload_size);                   
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                server.Stop();
            }

            Console.WriteLine("서버를 종료합니다.");
        }
    }
}
