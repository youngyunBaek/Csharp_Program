﻿using System;
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
            //const int bindPort = 5425;
            //TcpListener server = null;
            IPEndPoint ipep, ipep2 = null;
            UdpClient server, client = null;

            try
            {
                //IPEndPoint localAddress = new IPEndPoint(0, bindPort);
                server = new UdpClient(5425);

                ipep2 = new IPEndPoint(IPAddress.Any, 5426);                

                Console.WriteLine("파일 업로드 서버 시작... ");

                //server = new TcpListener(localAddress);
                //server.Start();

                while (true)
                {
                    //TcpClient client = server.AcceptTcpClient();
                    //Console.WriteLine("클라이언트 접속 : {0} ",((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    //NetworkStream stream = client.GetStream();
                    byte[] data = server.Receive(ref ipep2);
                    Stream stream = new MemoryStream(data);

                    Console.WriteLine("Receive Data");
                    Message reqMsg = MessageUtil.Receive(stream);

                    string hexOutput = String.Format("{0:X}", reqMsg.Header.id);
                    Console.WriteLine("id  0x{0} {1}", hexOutput, reqMsg.Header.id);
                    hexOutput = String.Format("{0:X}", reqMsg.Header.type);
                    Console.WriteLine("type  0x{0} {1}", hexOutput, reqMsg.Header.type);
                    hexOutput = String.Format("{0:X}", reqMsg.Header.size);
                    Console.WriteLine("size  0x{0} {1}", hexOutput, reqMsg.Header.size);
                    hexOutput = String.Format("{0:X}", ((BodyReq)reqMsg.Body).type);
                    Console.WriteLine("type  0x{0} {1}", hexOutput, ((BodyReq)reqMsg.Body).type);
                    hexOutput = String.Format("{0:X}", ((BodyReq)reqMsg.Body).id);
                    Console.WriteLine("type  0x{0} {1}", hexOutput, ((BodyReq)reqMsg.Body).id);

                    Message rspMsg = new Message();
                    rspMsg.Body = new BodyRes()
                    {
                        type = 0x0D,
                        id = 1,
                        data = new byte[] { 0x04, 0x05, 0x06 }
                    };
                    rspMsg.Header = new Header()
                    {
                        type = 0x0B,
                        id = 0x01,
                        size = 5
                    };

                    Console.WriteLine("Send Data");
                    server.Send(rspMsg.GetBytes(), rspMsg.GetSize(), "127.0.0.1", 5426);
                    
                    //MessageUtil.Send(stream, rspMsg);
                    //stream.Close();
                    //client.Close();                    
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {                
                client.Close();
            }

            Console.WriteLine("서버를 종료합니다.");
        }
    }    
}
