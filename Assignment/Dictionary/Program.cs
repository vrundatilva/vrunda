using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Id", "40");
            dict.Add("FirstName", "Mukesh");
            dict.Add("LastName", "Patel");
            dict.Add("Gender", "M");
            dict.Add("BatchYear", "2022-23");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
