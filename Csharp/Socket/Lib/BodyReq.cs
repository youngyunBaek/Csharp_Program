using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb
{
    public class BodyReq : ISerializable
    {
        public byte type { get; set; }
        public byte id { get; set; }
        public byte[] data { get; set; }

        public BodyReq() { }
        public BodyReq(byte[] bytes)
        {            
            type = bytes[0];
            id = bytes[1];
            data = new byte[bytes.Length - sizeof(byte) - sizeof(byte)];
            Array.Copy(bytes, sizeof(byte) + sizeof(byte), data, 0, data.Length);
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];
            bytes[0] = type;
            bytes[1] = id;
            Array.Copy(data, 0, bytes, sizeof(byte) + sizeof(byte), data.Length);

            return bytes;
        }

        public int GetSize()
        {
            return 5;
        }
    }
}
