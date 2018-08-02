using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using LIb;

namespace Server
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

                Console.WriteLine("파일 업로드 서버 시작... ");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("클라이언트 접속 : {0} ",
                       ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    NetworkStream stream = client.GetStream();

                    Message reqMsg = MessageUtil.Receive(stream);

                    Console.WriteLine("id    : " + reqMsg.Header.id);
                    Console.WriteLine("type  : " + reqMsg.Header.type);
                    Console.WriteLine("size  : " + reqMsg.Header.size);

                    Message rspMsg = new Message();
                    rspMsg.Header = new Header()
                    {
                        type = 0x0A,
                        id = 0x01,
                        size = 1
                    };

                    MessageUtil.Send(stream, rspMsg);
                    stream.Close();
                    client.Close();
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
