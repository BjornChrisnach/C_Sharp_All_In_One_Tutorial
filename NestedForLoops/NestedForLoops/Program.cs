using System;

namespace NestedForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i >= 0; i--)
            {
                //for (int k = 9; k >= 0; k--)
                for (int k = i; k >= 0; k--) // triangle shape
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();

            }

        }
    }
}
