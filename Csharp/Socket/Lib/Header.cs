using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb
{
    public class Header : ISerializable
    {
        public byte type { get; set; }
        public byte id { get; set; }
        public ushort size { get; set; }

        public Header() { }
        public Header(byte[] bytes)
        {
            type = bytes[0];
            id = bytes[1];
            size = BitConverter.ToUInt16(bytes, 2);
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            bytes[0] = type;
            bytes[1] = id;
            byte[] temp = BitConverter.GetBytes(size);
            Array.Copy(temp, 0, bytes, 2, temp.Length);

            return bytes;
        }

        public int GetSize()
        {
            return 4;
        }
    }
}
