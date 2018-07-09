using System;
using static System.Console;

namespace StringFormatBasic
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "sanghyun Park", "C# 7.0 Programming");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
