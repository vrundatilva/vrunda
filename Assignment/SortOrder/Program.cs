using System;

namespace SortOrder
{
    class Program
    {
        static void Main(string[] args)
        { 
            // declaring and initializing the array
            string[] arr = new string[] { "a","g","t","r","w","p" };

            // Sort array in ascending order.
            Array.Sort(arr);
            Console.WriteLine("Ascending: ");
            foreach (string value in arr)
            {
                Console.Write(value + " ");
            }

            // reverse array
            Array.Reverse(arr);
            Console.WriteLine("\n\nDescending: ");
            // print all element of array
            foreach (string value in arr)
            {
                Console.Write(value + " ");
            }
            Console.ReadLine();
        }
    }
}
