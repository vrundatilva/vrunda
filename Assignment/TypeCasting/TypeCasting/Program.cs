using System;

namespace TypeCasting
{
    class type
    {
        internal int a;
        internal long j;

        internal double b;
        internal int c;

    }
    class Program
    {
        static void Main(string[] args)
        {
            type t = new type();
            t.a = 50;
            t.j = t.a;//implicit
            t.b = 9.85;
            t.c = (int)t.b;//explicit
            Console.WriteLine($"{t.a}");
            Console.WriteLine($"{t.c}");

            Console.Read();
        }
    }
}
