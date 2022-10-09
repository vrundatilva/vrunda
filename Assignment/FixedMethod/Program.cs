using System;

namespace FixedMethod
{
    abstract class Abstract_Class
    {

        // Method declaration in abstract class
        public abstract void abstract_method();
    }
    interface Interface
    {

        // Method declaration in interface
        void interface_method();
    }
    class GFG : Abstract_Class, Interface
    {

        // Method definition for abstract method
        public override void abstract_method()
        {
            Console.WriteLine("I am the method of abstract class");
        }

        // Method definition for interface
        public void interface_method()
        {
            Console.WriteLine("I am the method of interface");
        }
    }
    class Geeks
    {

        // Driver code
        public static void Main(String[] args)
        {

            // Creating objects
            Abstract_Class ac = new GFG();
            Interface inf = new GFG();

            // Calling the methods of abstract class
            // and interface
            ac.abstract_method();
            inf.interface_method();
        }
    }
    
}
