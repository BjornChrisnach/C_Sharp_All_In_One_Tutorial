using System;

namespace YouTubeArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            // in CLI, cmd window, if you do, dotnet run, you will get an Error
            // Unhandled exception. System.IndexOutOfRangeException: Index was outside
            // the bounds of the array.
            Console.WriteLine(args[0]); // in CLI, you have to run it with an argument,
                                        // dotnet run args[0], so example dotnet run tacos,
                                        // that will display tacos in the cmd window

            // dotnet run -h, will not work, you have to use dotnet run -- -h, that displays -h

            Console.WriteLine(); // is overloaded with 18 different possibilities for
                                 // arguments, click on the up and down arrows to switch
                                 // between them
        }
    }
}
