using System;

namespace PrivateMember
{
    class PrivateVariable
    {
        private int i = 10; 
        public void DisplayVariable()
        {
            Console.Write("The Value of Private Variable=" + i);
            Console.ReadLine();
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            PrivateVariable objPrivateVariable = new PrivateVariable();
            objPrivateVariable.DisplayVariable();
        }
    }
}
