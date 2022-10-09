using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.age = 10;
            e.name = "vrunda";
            Console.WriteLine(e.age);
            Console.WriteLine(e.name);
            Console.ReadLine();

        }
    }
    public partial class Employee
    {
       public int age ;
    }
    public partial class Employee
    {
       public string name ;
    }
}
