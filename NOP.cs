// C# Program to illustrate the overloading of
// constructor when the number of parameters
// are different
using System;

namespace Constructor
{
    class ADD
    {

        int x, y;
        int f, p, s;

        // 1st constructor
        public ADD(int a, int b)
        {
            x = a;
            y = b;
        }

        // 2nd constructor
        public ADD(int a, int b, int c)
        {
            f = a;
            p = b;
            s = c;
        }

        // showing 1st constructor's result
        public void show()
        {
            Console.WriteLine("1st constructor (int + int): {0} ",
                                                        x + y);
        }

        // showing 2nd constructor's result
        public void show1()
        {
            Console.WriteLine("2nd constructor (int + int + int): {0}",
                                                        f + p + s);
        }
    }

    // Driver Class
    class NOP
    {

        // Main Method
     public static void main()
        {

            // will call 1st constructor
            ADD g = new ADD(10, 20);

            // calling method
            g.show();

            // will call 2nd constructor
            ADD q = new ADD(10, 20, 30);

            // calling method
            q.show1();

        }
    }
}