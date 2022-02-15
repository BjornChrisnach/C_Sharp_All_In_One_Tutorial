using System;

namespace YouTubeCharAndAsciiUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a'; // use single qoutes '', uses the char column of the asciitable,
                               // from for example: www.asciitable.com

            // Error, cannot implicitly convert type string to char
            //char letter2 = "a";

            int number = 'a'; // number displays 97, uses the decimal column of the asciitable,
                              // from for example: www.asciitable.com
            Console.WriteLine(number); // number displays 97

            int tab = '\t';
            Console.WriteLine(tab); // displays 9
            Console.WriteLine("Hello\tCaleb"); // displays Hello    Caleb

            char letter3 = (char)97; // Explicitly converts it from decimal to a char,
                                     // by typecasting it
            Console.WriteLine(letter3);
        }
    }
}
