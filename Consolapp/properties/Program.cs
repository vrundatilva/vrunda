using System;

namespace properties
{
    class Student
    {
        int id;
        public int empid
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.empid = 50;
            Console.WriteLine(s.empid);
            Console.Read();
        }
    }
}
