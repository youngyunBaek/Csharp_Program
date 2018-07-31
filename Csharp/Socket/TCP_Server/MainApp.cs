using System;
using System.Net.Sockets;
using System.Net;

namespace TCP_Server
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 로컬 포트 7000을 Listen
            TcpListener listener = new TcpListener(IPAddress.Any, 7000);
            listener.Start();
            Console.WriteLine("Start Listen...");

            byte[] buff = new byte[1024];

            while(true)
            {
                // TcpClient Connection 요청을 받아들여
                // 서버에서 새 TcpClient 객체를 생성하여 리턴
                TcpClient tc = listener.AcceptTcpClient();
                Console.WriteLine("Connect Client...");

                // TcpClient 객체에서 NetworkStream을 얻어옴
                NetworkStream stream = tc.GetStream();
                Console.WriteLine("Get Stream...");

                // 클라이언트가 연결을 끊을 때까지 데이터 수신
                int nbytes;
                while((nbytes = stream.Read(buff, 0, buff.Length)) > 0)
                {
                    // 데이터 그대로 송신
                    stream.Write(buff, 0, nbytes);
                }

                // 스트림과 TcpClient 객체
                stream.Close();
                tc.Close();

                // 계속 반복
            }
        }
    }
}
