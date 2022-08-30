
using System;
namespace Constructor
{
    class Test
    
    {
        //Declaration and initialization of static data member   
        private static int id = 5;
        public static int Id
        {
            get
            {
                return id;
            }
        }

        public static void print()
        {
            Console.WriteLine("Test.id = " + id);
        }

       public  static void main(string[] args)
        {
            //Print the value of id   
            Test.print();
            Test1.print();
        }

    }
    public class Test1
    {
        private static int id;
        //Static constructor, value of data member id is set conditionally here.   
        //This type of initialization is not possible at the time of declaration.  
        static Test1()
        {
            if (Test.Id < 10)
            {
                id = 20;
            }
            else
            {
                id = 100;
            }
            Console.WriteLine("Static<Class> Constructor for Class Test1 Called..");
        }
        public static void print()
        {
            Console.WriteLine("Test1.id = " + id);
        }
    }
    }