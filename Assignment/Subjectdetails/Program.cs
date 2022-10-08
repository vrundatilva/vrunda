using System;

namespace Subjectdetails
{
    class subject
    {
        public int a;
        public string suject1;
        public int b;
        public string subject2;
        public int c;
        public string subject3;
    }
    class Program
    {
        static void Main(string[] args)
        {
            subject s = new subject();
            s.suject1 = "Maths";
            s.a = 80;
            Console.WriteLine($" Subject1 : {s.suject1}  Marks: {s.a}");
            s.subject2 = "Science";
            s.b = 85;
            Console.WriteLine($" Subject2 : {s.suject1}  Marks: {s.b}");
            s.subject3 = "English";
            s.c = 60;
            Console.WriteLine($" Subject3 : {s.suject1}  Marks: {s.c}");

            int sum = s.a + s.b + s.c;
            Console.WriteLine($" sum of 3 subjects : {sum} ");

            float avg = sum / 3;
            Console.WriteLine($" sum of 3 subjects : {avg} ");

            Console.ReadLine();
        }
    }
}
