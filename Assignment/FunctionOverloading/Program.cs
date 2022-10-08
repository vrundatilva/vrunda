using System;

namespace FunctionOverloading
{
    class area
    {
        public double pi;
        public int r;
        public int l;
        public int b;
        public double h;
        public int W;
        public void shape(double a, int b)
        {
            pi = a;
            r = b;
            Console.WriteLine($"area of circle : pi*r*r\n");
            Console.WriteLine($" pi=3.14 ,r=10 :={pi*r*r}\n");

        }
        public void shape(int x, int y)
        {
            l = x;
            b = y;
            Console.WriteLine($"area of Rectangle : l*b\n");
            Console.WriteLine($" l=10 ,b=20 := {l*b}\n");

        }
        public void shape(int a, double v,int s)
        {
            b = a;
            h = v;
            W = s;
            Console.WriteLine($"area of Triangle : 1/2 *b*h\n");
            Console.WriteLine($"b=50,h=20 := {W*b*h}\n");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            area a = new area();
            a.shape(3.4,10);
            a.shape(10,20);
            a.shape(50,0.5,20);

            Console.ReadLine();
        }
    }
}
