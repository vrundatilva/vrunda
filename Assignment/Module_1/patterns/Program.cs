using System;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("program b\n");
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write("#");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }

            //    }
            //    Console.WriteLine();//output of b.
            //}
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("program c\n");

            ////c.
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            Console.Write("#");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }

            //    }
            //    Console.WriteLine();//output of c.
            //}
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("program d\n");

            ////d.
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();//output of d.
            //}
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("program e\n");

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();//output of e.
            //}
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("program f\n");

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();//output of f.
            //}
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Enter number count for Print 1+4+9+16+.... Series");
            //var number  = Convert.ToInt32(Console.ReadLine());
            //int count = 1;
            //while (count <= number)
            //{
            //    Console.Write($"{count * count} + ");
            //    count++;
            //}
            //Console.Write("........ ");
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Enter number count for Print  1+1+2+3+5+8+…+.... Series");
            //int num, firstNum = 1, secondNum = 1, temp, thirdNum = 3;
            //var cc1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write(firstNum + "\t" + secondNum);
            //int oldnum1= 1;
            ////Console.Write($"{oldnum1} + ");
            //while (thirdNum <= cc1)
            //{
            //    temp = firstNum + secondNum;
            //    Console.Write("\t" + temp);
            //    firstNum = secondNum; // assing secondNumb to firstNum  
            //    secondNum = temp; // assing temp number to secondNum  
            //    thirdNum = thirdNum + 1; // Increment the thirdNum  
            //    //Console.Write($"{thirdNum} + ");
            //    //oldnum1++;
            //}
            //Console.Write("........ ");
            //Console.ReadLine();
            int tt = 1;
            Console.Write($"{tt} + ");
            for (int i = 2; i <= 5; i++)
            {
                var newnum = (i * i) + tt;
                Console.Write($"{newnum} + ");
                tt = newnum;
            }
        }
    }
}
