using System;

namespace Constructor
{
    class User
    {
        public string name, location;
        // Parameterized Constructor
        public User(string a, string b)
        {
            name = a;
            location = b;
        }
        // Copy Constructor
        public User(User user)
        {
            name = user.name;
            location = user.location;
        }
    }
    class CopyConstructor
    {
        public static void main(string[] args)
        {
            User user = new User("Suresh Dasari", "Hyderabad");
           
            User user1 = new User(user);
            user1.name = "Rohini Alavala";
            user1.location = "Guntur";
            Console.WriteLine(user.name + ", " + user.location);
            Console.WriteLine(user1.name + ", " + user1.location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}