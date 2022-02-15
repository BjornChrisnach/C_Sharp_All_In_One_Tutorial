using System;

namespace YouTubeSinleLineIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Claire";

            /*
            // if you want two statements then you have to use {}, the second will be seen as outside
            // the curly braces even if there are none used
            if (name == "Claire") Console.WriteLine("You is lame"); Console.ReadLine();

            // or
            if (name == "Claire")
                Console.WriteLine("You is lame"); 
            Console.ReadLine(); // even the automatic indentation, sees it is outside the if block 
            */

            // only this is allowed
            if (name == "Claire") Console.WriteLine("You is lame");

            // or
            if (name == "Claire")
                Console.WriteLine("You is lame");

        }
    }
}
