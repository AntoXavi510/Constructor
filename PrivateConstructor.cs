using System;

class Geeks
{

    // Variables
    public static string? name;
    public static int num;

    // Creating private Constructor
    // using private keyword
    private Geeks()
    {
        Console.WriteLine("Welcome to Private Constructor");
    }

    // Default Constructor
    // with parameters
    public Geeks(string a, int b)
    {

        name = a;
        num = b;
    }
}

// Driver Class
class GFG
{

    // Main Method
  public  static void main()
    {

        // This line raises error because the constructor is inaccessible
        // Geeks obj1 = new Geeks();
        Geeks obj2 = new Geeks("Ankita", 2);

        Console.WriteLine(Geeks.name + ", " + Geeks.num);
    }
}