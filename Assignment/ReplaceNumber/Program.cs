using System;

namespace ReplaceNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " Mukesh Patel";
            string res = str.Replace("Mukesh ", "Akash ");
            Console.WriteLine($" Enter Name :{str}\n");

            Console.WriteLine($" Replace with New name :{res}");
            Console.ReadLine();
        }
    }
}
