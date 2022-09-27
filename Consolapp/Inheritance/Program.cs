using System;

namespace Inheritance
{
    class animal
    {
        public  string name = "dog";
        public void Display()
        {
            Console.WriteLine("i am an animal");
        }
    }
    class dog : animal
    {
        public void Getname()
        {
            Console.WriteLine($" My name is  := {name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dog a = new dog();
            a.Getname();
            Console.ReadLine();

        }
    }
}
