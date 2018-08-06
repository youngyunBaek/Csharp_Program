using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Program
    {   

        static void Main(string[] args)
        {
            byte input;
            byte[] input2;
            byte input3;

            byte test = 0x1;
            byte test3 = 0x02;
            byte[] test2 = new byte[] { 0x02, 0x03, 0x04 };

            byte[] bytes = new byte[5];
            bytes[0] = test;
            bytes[1] = test3;            
            
            Array.Copy(test2, 0, bytes, sizeof(byte)+sizeof(byte), test2.Length);

            Console.WriteLine(bytes[0]);
            Console.WriteLine(bytes[1]);
            Console.WriteLine(bytes[2]);
            Console.WriteLine(bytes[3]);
            Console.WriteLine(bytes[4]);

            input = bytes[0];
            input3 = bytes[1];
            input2 = new byte[bytes.Length - sizeof(byte) - sizeof(byte)];
            Array.Copy(bytes, sizeof(byte) + sizeof(byte), input2, 0, input2.Length);

            Console.WriteLine(input);
            Console.WriteLine(input3);
            Console.WriteLine(input2[0]);
            Console.WriteLine(input2[1]);
            Console.WriteLine(input2[2]);            
        }
    }
}
