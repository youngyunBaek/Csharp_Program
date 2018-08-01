using System;

namespace Lib
{
    public class Header : ISerializable
    {
        public byte Packet_Type { get; set; }
        public byte Current_Sequence { get; set; }
        public ushort Payload_size { get; set; }

        public Header() { }
        public Header(byte[] bytes)
        {
            Packet_Type = bytes[0];
            Current_Sequence = bytes[1];
            Payload_size = BitConverter.ToUInt16(bytes, 2);
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[4];

            bytes[0] = Packet_Type;
            bytes[1] = Current_Sequence;

            byte[] temp = BitConverter.GetBytes(Payload_size);
            Array.Copy(temp, 0, bytes, 2, temp.Length);

            return bytes;
        }

        public int GetSize()
        {
            return 4;
        }
    }
}
