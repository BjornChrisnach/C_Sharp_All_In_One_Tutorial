using System;

namespace YouTubeUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine(), returns a string it has a return type it's not void
            //Console.ReadLine(); // in cmd window, dotnet run command, and it waits for user
            // input, you can type something and then hit enter to go on
            // with execution, but what you type will not appear in the
            // console window

            // var finds out what type it's going to be for us, if we don't know ourselves, if
            // You hover over var, it says it a string, so we can easily use string instead

            // var x = Console.ReadLine(); // put the return string in variable x, '=' is 
            // called the assignment operator
            // run in the cmd window with command dotnet run,
            // type in a string and hit enter

            /*
            string x = Console.ReadLine();
            Console.WriteLine("Yo");
            Console.WriteLine(x); // write the user input, the string x to the console window
            */

            string name = Console.ReadLine();
            // Console.WriteLine("Hello " + name + "!"); // here '+' is the concatination
                                                      // operator, it concationates Hello
                                                      // with the user input 'name' and the
                                                      // exclamation sign

            Console.WriteLine($"Hello, {name}!"); // string interpolation with the $ sign

            Console.WriteLine("Hello, {0}!", name); // string interpolation without the
                                                    // $ sign

        }
    }
}
