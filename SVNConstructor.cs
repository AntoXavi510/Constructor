using System;

namespace Constructor
{
    class Geeks
    {
        // Declaration of
        // static constructor
      static Geeks()
        {
            Console.WriteLine("It is static constructor");
        }

        // Declaration of
        // non-static constructor
        public Geeks()
        {
            Console.WriteLine("It is non-static constructor");
        }

        // Main Method
     public static void main(string[] args)
        {

            // Static constructor will call implicitly
            // as soon as the class start to execute
            // the first block of code to execute
            // will be static constructor

            // Calling non-static constructor
            Geeks obj1 = new Geeks();
            Geeks obj2 = new Geeks();
        }
    }
}