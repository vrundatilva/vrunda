using System;

namespace ConsoleApp1
{
    class TASK
    {
        int a;
        string value = string.Empty;
        public void Show()
        {
            //Console.WriteLine("VALUE TYPE TO REFERENCE TYPE:");
            //Console.Write("Enter id: ");
            //a =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("REFERENCE TYPE TO VALUE TYPE:");
            //testing
            //Console.Write("Enter name: ");
            //value =(Console.ReadLine());

            int x = 10;  // value type

            object xy = 2; //reference type
                           // Console.WriteLine(xy);

            object z = x;
            Console.WriteLine($"VALUE TYPE TO REFERENCE TYPE:{z}");//VALUE TYPE TO REFERENCE TYPE
            int y = Convert.ToInt32(xy);
            Console.WriteLine($"REFERENCE TYPE TO VALUE TYPE::{y}");//"REFERENCE TYPE TO VALUE TYPE:


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Type");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Integers:\n");
            byte a = byte.MinValue;
            Console.WriteLine("minimum value of byte = " + a);
            byte b = byte.MaxValue;
            Console.WriteLine("maximum value of byte = " + b);
            sbyte c = sbyte.MinValue;
            Console.WriteLine("minimun value of syte = " + c);
            sbyte d = sbyte.MaxValue;
            Console.WriteLine("maximum value of syte = " + d);
            short e = short.MinValue;
            Console.WriteLine("minimun value of short = " + e);
            short f = short.MaxValue;
            Console.WriteLine("maximum value of short = " + f);
            ushort g = ushort.MinValue;
            Console.WriteLine("minimun value of ushort = " + g);
            ushort h = ushort.MaxValue;
            Console.WriteLine("maximum value of ushort = " + h);
            int i = int.MinValue;
            Console.WriteLine("minimun value of int = " + i);
            int j = int.MaxValue;
            Console.WriteLine("maximum value of int = " + j);

            float k = float.MinValue;
            Console.WriteLine("minimun value of float =  " + k);
            float l = float.MaxValue;
            Console.WriteLine("maximum value of float =  " + l);
            double m = double.MinValue;
            Console.WriteLine("minimun value of double =  " + m);
            double n = double.MaxValue;
            Console.WriteLine("maximum value of double =  " + n);
            decimal o = decimal.MinValue;
            Console.WriteLine("minimun value of decimal =  " + o);
            decimal p = decimal.MaxValue;
            Console.WriteLine("maximum value of decimal  = " + p);

            TASK myclass = new TASK();
            myclass.Show();
            Console.ReadKey();
        }
    }
}
