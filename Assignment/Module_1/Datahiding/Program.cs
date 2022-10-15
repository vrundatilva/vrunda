using System;

namespace Datahiding
{
    public class My_Family
    {
        public void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class
    public class My_Member : My_Family
    {
        // Using new keyword
        // It hides the method of the base class
        public new void member()
        {
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                   "Age: 39 \nName: Rohan, Age: 20 ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            My_Member obj = new My_Member();

            // Access the method of derived class
            obj.member();
            Console.ReadLine();
        }
    }
}
