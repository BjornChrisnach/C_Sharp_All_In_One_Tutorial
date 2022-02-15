using System;

namespace NestedControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            bool logging = true;

            for (int i = 9; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
                if(i == 7)
                {
                    if(logging == true)
                    {
                        Console.WriteLine("We found 7!");
                    }
                }
            }

            /*
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
            for (int i = 9; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            */

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
