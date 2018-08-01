using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lib
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
            int sizeToRead = 16;
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

            totalRecv = 0;
            byte[] bBuffer = new byte[header.Payload_size];
            sizeToRead = (int)header.Payload_size;

            while(sizeToRead > 0)
            {
                byte[] buffer = new byte[sizeToRead];
                int recv = reader.Read(buffer, 0, sizeToRead);
                if (recv == 0)
                    return null;

                buffer.CopyTo(bBuffer, totalRecv);
                totalRecv += recv;
                sizeToRead -= recv;
            }

            ISerializable body = null;
            switch (header.Packet_Type)
            {
                case CONSTANS.A:
                    body = new BodyRequest(bBuffer);
                    break;
                case CONSTANS.B:
                    body = new BodyResponse(bBuffer);
                    break;
                case CONSTANS.C:
                    break;
                case CONSTANS.D:
                    break;
                default:
                    throw new Exception(
                        String.Format(
                            "Unknown MSGTYPE : {0}" + header.Packet_Type));

            }

            return new Message() { Header = header, Body = body };
        }
    }
}
