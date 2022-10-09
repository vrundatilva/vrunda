using System;

namespace ReplaceChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world";
            Console.WriteLine("Initial string = " + str);
            string res = str.Replace('H', 'k');
            // after replacing
            Console.WriteLine("Replaced string = " + res.ToString());
        }
    }
}
