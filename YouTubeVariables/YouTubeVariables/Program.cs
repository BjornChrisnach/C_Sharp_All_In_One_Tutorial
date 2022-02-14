using System;

namespace YouTubeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5; // (int) x is a variable of type int, where x is the identifier
            
            // Error, identifier expected
            // int 5x = 4; // identifiers can't start with a number, from the special chracters
            // -> they can only start with an underscore _ or $ sign

            // are ok
            int x55 = 4;
            int X = 50; // smallcase x and uppercase X are 2 different identifiers

            // var y = "Hello"; // It's going to be a string, but if you change it
            // var y = 5; // It's going to be an integer, type int

            string name = Console.ReadLine(); // (string) name is a variable of type string, 
            // where name is the identiefier

            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine("Yo");
            */

            //int x = 5;

            /*
            // Print it 5 times to the cmd or console window, but if the variable changes we
            // need to change all 5 statements
            Console.WriteLine(5);
            Console.WriteLine(5);
            Console.WriteLine(5);
            Console.WriteLine(5);
            Console.WriteLine(5);
            */

            /*
            // so we use Console.WriteLine(x) instead, we only change it in one statement
            // int x = 6
            int x = 6;

            Console.WriteLine(x);
            Console.WriteLine(x);
            Console.WriteLine(x);
            Console.WriteLine(x);
            Console.WriteLine(x);
            */

            string x = "Caleb";
            Console.WriteLine(x + " is weird."); // expression evaluates to one larger string,
            // x is an operand and " is weird." is an operand
            // furthermore x or "Caleb" is concatenated with " is weird." by the '+' operator
            // string x is a variable, " is weird." is a literal

        }
    }
}

// variables - stores some value
// literal - actual value
// identifier - what we call the variable
// Expression - evaluates to a value
// operator - it works on operands
// operand - the thing(s) that the operator works on