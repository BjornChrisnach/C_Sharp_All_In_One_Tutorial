using System;

namespace YouTubeVariables2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 5; //, LeftToRight -> DataType, identifier, assignment operator, value
            // declaration and initialization

            /*
            int y; // declaration
            //y = 5; // initialization

            Console.WriteLine(y); // and we comment out y = 5;, we get an Error, 
            // Use of unassigned local variable 'y'
            // the value would be undefined
            */

            /*
            // int y; // declaration outside the if block, the variable y would still exist
                   // to further statements

            if ()
            {
                int y = 5; // declaration inside the if block, but 'y' would not exist for
                           // further statements after the if block
            }
            */

            int? y = null; // nullable datatypes use the ? after the datatype, int?

            // the code compiles with use of null
            Console.WriteLine(y);
        }
    }
}
