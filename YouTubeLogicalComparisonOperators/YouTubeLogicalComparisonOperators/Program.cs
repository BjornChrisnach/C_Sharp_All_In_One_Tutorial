using System;

namespace YouTubeLogicalComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo noob wuts ur age?");
            int age = Int32.Parse(Console.ReadLine()); // ReadLine() returns a string, we need to convert it to int

            Console.WriteLine("Dawg whats the pass?");
            string password = Console.ReadLine();

            // > greater than comparison operator, combined with the Logical 'AND' operator -> &&
            if (age > 12 && password == "password123")
            {
                Console.WriteLine("Welcome! You're atleast a teenager and got the correct password");
            }
        }
    }
}
