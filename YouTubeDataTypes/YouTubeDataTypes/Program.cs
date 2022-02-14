using System;

namespace YouTubeDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // sîmple types and value types
            int a = -5; // int is the datatype, stands for integer, 5 is a literal and
                        // literals can be assigned to variables, int can assign positive and
                        // negative values to the variable

            // Error, Constant value '-5' cannot be converted to a 'uint'
            // uint b = -5; // uint can't assign negative values to the variable
            uint b = 5;

            char c = 'C'; // for char single quotes '' are used, for a string
                          // double quotes "" are used

            // Error, Literal of type double cannot be implicitly converted to type 'float';
            // use an 'F' suffix to create a literal of this type
            // float d = 5.5; without the suffix f or F, it's seen as a double
            float d = 5.5F;

            double e = 5.5;

            decimal f = 5.5M; // without the suffix M, it's seen as a double, is used when
                              // you need exact precision, like when you deal with money

            bool g = true; // true or false value

            // Not a simple type but it acts like one, it's a reference type not a value type
            string h = "Hello";



        }
    }
}
