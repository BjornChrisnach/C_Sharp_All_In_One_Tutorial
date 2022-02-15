using System;

namespace YouTubeMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double x = 50.5;
            //Console.WriteLine(Math.Round(x)); // uses bankers rounding, rounds to closest even
                                              // number 50 is closer

            Console.WriteLine(Math.Round(x,0,MidpointRounding.AwayFromZero)); // displays 51
            */

            /*
            double x = 50.9;
            Console.WriteLine(Math.Floor(x)); // displays 50
            Console.WriteLine(Math.Ceiling(x)); // displays 51
            Console.WriteLine(Math.Truncate(x)); // displays 50, shops of after the decimal point
            */

            /*
            double x = 50.9;
            double y = 300;
            Console.WriteLine(Math.Min(y, x)); // displays x, 50.9
            Console.WriteLine(Math.Max(y, x)); // displays y, 300
            */

            double x = -50.9;
            Console.WriteLine(Math.Abs(x)); // displays the absolute value, so positive only
                                            // 50.9 io -50.9

            Console.WriteLine(Math.Sign(x)); // displays -1, is less then zero;
                                             // if it displays 0 then it is zero;
                                             // if it displays 1 it is above zero


        }
    }
}
