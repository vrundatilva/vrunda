using System;

namespace Overiding
{
    class overloading
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        static void Main(string[] args)
        {
            overloading a = new overloading();
            int sum1 = a.Add(1, 2);
            Console.WriteLine($" sum of two values := {sum1}");
            int sum2 = a.Add(1, 2, 5);
            Console.WriteLine($" sum of three values := {sum2}");
            Console.Read();

        }
    }
}
