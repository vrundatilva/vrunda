using System;

namespace Constructor
{
    class student
    {
        public int a;
        public int b;
        public int c;
        public  student(int x,int y,int z)
        {
            a = x;
            b = y;
            c = z;
        }
        public void add()
        {
            Console.WriteLine($"Addition of three numbers :");
            Console.WriteLine($"a={a} ,b={b},c={c} ");
            Console.WriteLine($" a+b+c= {a + b + c}\n");
        }
        public void Sub()
        {
            Console.WriteLine($"Subtraction of two numbers  :");
            Console.WriteLine($"a={a} ,b={b} ");
            Console.WriteLine($" a-b = {a -b}\n");
        }
        public void Div()
        {
            Console.WriteLine($"Division of two numbers :");
            Console.WriteLine($" b={b},c={c} ");
            Console.WriteLine($" c/b= {c/b}\n");
        }
        public void Multi()
        {
            Console.WriteLine($"Multiplication of three numbers:");
            Console.WriteLine($"a={a} ,b={b},c={c} ");
            Console.WriteLine($" a*b*c= {a * b * c}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student(50,40,80);
            s.add();
            s.Sub();
            s.Div();
            s.Multi();
            Console.ReadLine();
        }
    }
}
