﻿// C# program to Demonstrate the overloading of
// constructor when the types of arguments
// are different
using System;

class ADD
{

	int x, y;
	double f;
	string s;

	// 1st constructor
	public ADD(int a, double b)
	{
		x = a;
		f = b;
	}

	// 2nd constructor
	public ADD(int a, string b)
	{
		y = a;
		s = b;
	}

	// showing 1st constructor's result
	public void show()
	{
		Console.WriteLine("1st constructor (int + float): {0} ",
													(x + f));
	}

	// shows 2nd constructor's result
	public void show1()
	{
		Console.WriteLine("2nd constructor (int + string): {0}",
													(s + y));
	}
}

// Driver Class
class TOP
{

	// Main Method
	public static void main()
	{

		// Creating instance and
		// passing arguments
		// It will call the first constructor
		ADD g = new ADD(10, 20.2);

		// calling the method
		g.show();


		// Creating instance and
		// passing arguments
		// It will call the second constructor
		ADD q = new ADD(10, "Roll No. is ");

		// calling the method
		q.show1();
	}
}
