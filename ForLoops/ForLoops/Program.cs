using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // in general, use for loops if you know how many times you need to iterate through the code,
            // use while loops if you dont know in advance how many times you have to loop

            // i++, until i < 10
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                // i++ hapens here
            }

            Console.WriteLine(" ");

            // i--, unitl i >= 0
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");

            // i-=2, unitl i >= 0
            for (int i = 9; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }

            /*
            int i = 0; // initialization
            do
            {
                Console.WriteLine(i);
                i++; // update
            }
            // while (i < 10); // condition
            // while (i < 0);
            while (false);
            */

            /*
            int i = 0; // initialization
            while (i < 10) // condition
            {
                Console.WriteLine(i);
                i++; // update
            }
            */
        }
    }
}
