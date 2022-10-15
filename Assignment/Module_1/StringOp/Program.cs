using System;

namespace StringOp
{
    class Program
    {
      public  class stringoperation
        {
            internal string name = "c# programing";
            internal string name2 = "2";
            internal string name3 = "c# programing2";

        }
        static void Main(string[] args)
        {
            stringoperation s = new stringoperation();

            Console.WriteLine($"{s.name}");
            //int length =Convert.ToInt32(s.name);
            // Get the Length of a string
            //Console.WriteLine("");
            Console.WriteLine($"1. Get the Length of a string: {s.name.Length}\n");

            //join two string in c#
            //Console.WriteLine("");

            string join = string.Concat(s.name, s.name2);
            Console.WriteLine($"2. join two string in c# :{join}\n");


            // C# compare two strings

            Boolean equal = s.name.Equals(s.name2);
            Console.WriteLine($" 3. string name and name2 are equal: {equal}\n");

            Boolean equal1 = s.name.Equals(s.name3);
            Console.WriteLine($"3. string name and name3 are equal: {equal1}\n");

            //c# ToUpper
            Console.WriteLine($"4. Convert the string to upper: {s.name.ToUpper()}\n");

            //replace

            string replace = s.name3.Replace(s.name2,s.name2);
            Console.WriteLine($"5. Replaces the specified old character with the specified new character: {replace}\n");

            Console.ReadLine();
        }
    }
}
