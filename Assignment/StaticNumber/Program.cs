using System;

namespace StaticNumber
{
    class Program
    {
        public static int Var;//static field
        static void Main(string[] args)
        {
            //Program p1 = new Program();  //a object of class  
            Var = 10;
            Console.WriteLine(Var);
            Console.ReadKey();
        }
    }
}
