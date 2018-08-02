using System;
using System.IO;

namespace LIb
{
    public class MessageUtil
    {
        public static void Send(Stream writer, Message msg)
        {
            writer.Write(msg.GetBytes(), 0, msg.GetSize());
        }

        public static Message Receive(Stream reader)
        {
            int totalRecv = 0;
            int sizeToRead = 4;
            byte[] hBuffer = new byte[sizeToRead];

            while(sizeToRead > 0)
            {
                byte[] buffer = new byte[sizeToRead];
                int recv = reader.Read(buffer, 0, sizeToRead);
                if (recv == 0)
                    return null;

                buffer.CopyTo(hBuffer, totalRecv);
                totalRecv += recv;
                sizeToRead -= recv;
            }

            Header header = new Header(hBuffer);

            return new Message() { Header = header };
        }
    }
}
