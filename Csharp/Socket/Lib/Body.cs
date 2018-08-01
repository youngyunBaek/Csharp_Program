using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class BodyRequest : ISerializable
    {
        public byte Device_Type;
        public byte[] Device_Id;
        public byte[] VIN;
        public uint Vehicle_Id;

        public BodyRequest() { }
        public BodyRequest(byte[] bytes)
        {
            Device_Type = bytes[0];            
            Device_Id = new byte[bytes.Length - sizeof(byte) - VIN.Length - sizeof(uint)];
            Array.Copy(bytes, sizeof(byte), Device_Id, 0, Device_Id.Length);
            VIN = new byte[bytes.Length - sizeof(byte) - Device_Id.Length - sizeof(uint)];
            Array.Copy(bytes, sizeof(byte) + Device_Id.Length, VIN, 0, VIN.Length);
            Vehicle_Id = BitConverter.ToUInt16(bytes, sizeof(byte) + Device_Id.Length + VIN.Length);
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];
            byte[] temp = BitConverter.GetBytes(Device_Type);
            Array.Copy(temp, 0, bytes, 0, temp.Length);
            Array.Copy(Device_Id, 0, bytes, temp.Length, Device_Id.Length);
            Array.Copy(VIN, 0, bytes, temp.Length, VIN.Length);
            temp = BitConverter.GetBytes(Vehicle_Id);
            Array.Copy(temp, 0, bytes, sizeof(byte)+Device_Id.Length+VIN.Length, temp.Length);

            return bytes;
        }

        public int GetSize()
        {
            return sizeof(byte) + Device_Id.Length + VIN.Length + sizeof(uint);
        }
    }

    public class BodyResponse : ISerializable
    {
        public byte Device_Type;
        public byte[] Device_Id;
        public byte Registration_Status;

        public BodyResponse() { }
        public BodyResponse(byte[] bytes)
        {
            Device_Type = bytes[0];
            Device_Id = new byte[bytes.Length - sizeof(byte) - sizeof(byte)];
            Array.Copy(bytes, sizeof(byte), Device_Id, 0, Device_Id.Length);
            Registration_Status = bytes[4];
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];
            byte[] temp = BitConverter.GetBytes(Device_Type);
            Array.Copy(temp, 0, bytes, 0, temp.Length);
            Array.Copy(Device_Id, 0, bytes, temp.Length, Device_Id.Length);
            temp = BitConverter.GetBytes(Registration_Status);
            Array.Copy(temp, 0, bytes, sizeof(byte)+Device_Id.Length, temp.Length);

            return bytes;
        }

        public int GetSize()
        {
            return sizeof(byte) + Device_Id.Length + sizeof(byte);
        }
    }
}
