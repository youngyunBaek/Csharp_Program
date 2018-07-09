using System;
using static System.Console;

namespace A_StringSlice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";

            WriteLine(greeting.Substring(0, 5)); // "morning"
            WriteLine(greeting.Substring(5)); // "Good"
            WriteLine();

            String[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Cound : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
    }
}
