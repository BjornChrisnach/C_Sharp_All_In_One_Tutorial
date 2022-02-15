using System;

namespace YouTubeTernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ternary
            //expression ? true : false

            bool correct = true;

            int pointsEarned = correct ? 10 : 0;
            Console.WriteLine(pointsEarned);
            */

            // if else
            bool correct = true;
            int pointsEarned;

            if(correct)
            {
                pointsEarned = 10;
            }
            else
            {
                pointsEarned = 0;
            }
            Console.WriteLine(pointsEarned);

        }
    }
}
