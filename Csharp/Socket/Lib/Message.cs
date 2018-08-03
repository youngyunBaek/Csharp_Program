﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb
{
    public interface ISerializable
    {
        byte[] GetBytes();
        int GetSize();
    }

    public class Message : ISerializable
    {
        public Header Header { get; set; }
        public ISerializable BodyReq { get; set; }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            Header.GetBytes().CopyTo(bytes, 0);
            BodyReq.GetBytes().CopyTo(bytes, Header.GetSize());

            return bytes;
        }

        public int GetSize()
        {
            return Header.GetSize() + BodyReq.GetSize();
        }
    }
}
