// C# program to illustrate the invoking of
// overloaded constructor using this keyword
using System;

namespace Constructor
{
    class GFG
    {

        // Private data members
        private int Length, Height;
        private double Width;

        // Default Constructor
        public GFG()
        {
            Console.WriteLine("Default Constructor Invoked");
        }

        // The constructor calls the
        // Default constructor
        public GFG(int l, double w) : this()
        {
            Console.WriteLine("Parameterized Constructor in 2nd Constructor");

            // assigning value of
            // 'Length'and 'Width'
            Length = l;
            Width = w;

        }

        // The constructor call the
        // parameterized constructor
        public GFG(int l, double w, int h) : this(l, w)
        {
            Console.WriteLine("Parameterized Constructor in 3rd Constructor");

            // assign value of 'Height'
            Height = h;

        }

        // Public Method to calculate volume
        public double Volume()
        {
            return Length * Width * Height;
        }
    }

    // Driver Class
    class This
    {

        // Main Method
        public static void main()
        {

            // Invoking 3rd Constructor
            // here Constructor chaining
            // came into existence
            GFG g = new GFG(10, 20.5, 30);

            // calling the 'Volume' Method
            Console.WriteLine("Volume is : {0}", g.Volume());

        }
    }
}