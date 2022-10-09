using System;

namespace StudentData
{
    class Person
    {
        public string name;
        public int age;
        public Person()
        {
            this.age = 10;
            this.name = "test";
        }
        public int getage()
        {
            return age;
        }
        public string getname()
        {
            return name;
        }
        public void setage(int age)
        {
            this.age = age;
        }
        public void setname(string name)
        {
            this.name = name;
        }
    }
    class student:Person
    {
        public student()
        {
            this.percentage = 0;
        }
        public double percentage;
        public double getpercentage()
        {
            return percentage;
        }
        public void setpercentage(double percentage)
        {
            this.percentage = percentage;
        }
    }
    class teacher : student
    {
        public teacher()
        {
            this.salary = 0;
        }
        public double salary;
        public double getsalary()
        {
            return salary;
        }
        public void setsalary(double sal)
        {
            salary = sal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
