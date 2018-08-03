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

        public BodyReq() { }
        public BodyReq(byte[] bytes)
        {
            type = bytes[0];
            id = bytes[1];
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];
            bytes[0] = type;
            bytes[1] = id;

            return bytes;
        }

        public int GetSize()
        {
            return 2;
        }
    }
}
