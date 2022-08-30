// C# program to illustrate the overloading of
// constructor by changing the order of parameters
using System;

class student
{

	public int roll;
	public double Height;
	public string name;

	public student(double a, int x, string s)
	{
		roll = x;
		name = s;
		Height = a;
	}

	// order of the argument is different
	// with respect to 1st constructor
	public student(string s, int x, double a)
	{
		Height = a;
		roll = x;
		name = s;
	}

	public void show()
	{
		Console.WriteLine("Roll Number: " + roll);
		Console.WriteLine("Height: " + Height + "feet");
		Console.WriteLine("Name: " + name);
	}
}

// Driver Class
class OOP
{

	// Main Method
	public static void main()
	{

		// invoking 1st constructor
		student s1 = new student(5.7, 10, "Jhon Peterson");

		// invoking 2nd constructor
		student s2 = new student("Peter Perker", 11, 6.0);

		Console.WriteLine("First Constructor: ");
		s1.show();

		Console.WriteLine();

		Console.WriteLine("Second Constructor: ");
		s2.show();

	}
}
