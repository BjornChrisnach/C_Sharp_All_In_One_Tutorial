using System;

namespace YouTubeStringEscapeSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            // Error, unrecognized escape sequence
            //string name = "\hello my name is Caleb!";

            /*
            string name = "\ahello my name is Caleb!"; 
            Console.WriteLine(name); // produces a sound, like chimes
            */

            /*
            string name = "hello my name is \"Caleb!\"";
            Console.WriteLine(name); // displays, hello my name is "Caleb!"
            */

            /*
            // Error, Empty character literal
            //char letter = ''';

            char letter = '\'';
            */

            /*
            string name = "hello my name \\is Caleb!";
            Console.WriteLine(name); // displays, hello my name \is Caleb!
            */

            // verbatim identifier, @
            string name = @"hello my \tname \is Caleb!";
            Console.WriteLine(name); // displays, hello my \tname \is Caleb!

            name = @"hello my \tname \is ""Caleb""!";
            Console.WriteLine(name); // displays, hello my \tname \is "Caleb"!

        }
    }
}
