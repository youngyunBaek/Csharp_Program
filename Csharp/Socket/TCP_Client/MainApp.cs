using System;
using System.Net.Sockets;
using System.Text;

namespace TCP_Client
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // IP 주소와 포트를 지정하고 TCP 연결
            TcpClient tc = new TcpClient("127.0.0.1", 7000);
            //TcpClient tc = new TcpClient("localhost", 7000);

            string msg = "Hello world";
            byte[] buff = Encoding.ASCII.GetBytes(msg);

            // NetworkStream을 얻어옴
            NetworkStream stream = tc.GetStream();

            // 스트림 바이트 데이터 전송
            stream.Write(buff, 0, buff.Length);

            // 스트림으로부터 바이트 데이터 읽기
            byte[] outbuf = new byte[1024];
            int nbytes = stream.Read(outbuf, 0, outbuf.Length);
            string output = Encoding.ASCII.GetString(outbuf, 0, nbytes);

            // 스트림과 TcpClient 객체 닫기
            stream.Close();
            tc.Close();

            Console.WriteLine($"{nbytes} bytes: {output}");
        }
    }
}
