using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1, num;

            Console.Write("Calculate the factorial of a given number:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;
            Console.Write($"The Factorial of {num} is  : {f}\n");

            Console.ReadLine();
        }
    }
}
