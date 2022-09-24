using System;

namespace overriding
{
    class bird//base class
    {
       public virtual void fly()
        {
            Console.WriteLine("Birds are Flying");
        }
    }
    class Peacock : bird
    {
        public override void fly()
        {
            Console.WriteLine("Peacock are Flying");
        }
}
    class program
    {
        static void Main(string[] args)
        {
            bird p = new Peacock();
            p.fly();
            Console.ReadLine();
        }
    }
}
