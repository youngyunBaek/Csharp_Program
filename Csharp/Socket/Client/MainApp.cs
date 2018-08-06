using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using LIb;

namespace Client
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string serverIp = "127.0.0.1";
            const int serverPort = 5425;            

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(0, 0);
                IPEndPoint serverAddress =
                    new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                Console.WriteLine("클라이언트: {0}, 서버:{1}",
                    clientAddress.ToString(), serverAddress.ToString());

                Message reqMsg = new Message();
                reqMsg.Body = new BodyReq()
                {
                    type = 0x0C,
                    id = 0,
                    data = new byte[] { 0x01, 0x02, 0x03 }
                };
                reqMsg.Header = new Header()
                {
                    type = 0x0A,
                    id = 0x02,
                    size = 5
                };

                TcpClient client = new TcpClient(clientAddress);
                client.Connect(serverAddress);

                NetworkStream stream = client.GetStream();

                MessageUtil.Send(stream, reqMsg);

                Message rspMsg = MessageUtil.Receive(stream);

                Console.WriteLine("Receive Data");

                string hexOutput = String.Format("{0:X}", rspMsg.Header.id);                
                Console.WriteLine("id  0x{0} {1}", hexOutput, rspMsg.Header.id);

                hexOutput = String.Format("{0:X}", rspMsg.Header.type);
                Console.WriteLine("type  0x{0} {1}", hexOutput, rspMsg.Header.type);

                hexOutput = String.Format("{0:X}", rspMsg.Header.size);
                Console.WriteLine("size  0x{0} {1}", hexOutput, rspMsg.Header.size);

                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("클라이언트를 종료합니다.");
        }
    }
}
