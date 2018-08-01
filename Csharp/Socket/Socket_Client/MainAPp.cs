using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Lib;

namespace Socket_Client
{
    class MainApp
    {
        const int CHUNK_SIZE = 4096;

        static void Main(string[] args)
        {
            String serverIp = "127.0.0.1";
            const int serverPort = 5425;

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(0, 0);
                IPEndPoint serverAddress =
                    new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                Console.WriteLine("클라이언트: {0}, 서버:{1}",
                    clientAddress.ToString(), serverAddress.ToString());

                uint msgId = 0;

                Message reqMsg = new Message();
                reqMsg.Body = new BodyRequest()
                {
                    Device_Type = 0xD1,
                    
                };
            }
        }
    }
}
