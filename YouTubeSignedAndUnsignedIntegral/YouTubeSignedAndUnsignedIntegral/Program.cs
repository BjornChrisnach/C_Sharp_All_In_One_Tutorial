using System;

namespace YouTubeSignedAndUnsignedIntegral
{
    class Program
    {
        static void Main(string[] args)
        {
            // int.MaxValue // hover over and u get 2.147.483.647
            // int.MinValue // hover over and u get -2.147.483.648

            // uint.MaxValue // hover over and u get 4.294.967.295
            // uint.MinValue // hover over and u get 0

            // short.MaxValue // hover over and u get 32.767
            // short.MinValue // hover over and u get -32768

            // ushort.MaxValue // hover over and u get 65.535
            // ushort.MinValue // hover over and u get 0

            // sbyte.MaxValue // hover over and u get 127
            // sbyte.MinValue // hover over and u get -128

            // byte.MaxValue // hover over and u get 255
            // byte.MinValue // hover over and u get 0

            // long.MaxValue // hover over and u get 9.223.372.036.854.775.807
            // long.MinValue // hover over and u get -9.223.372.036.854.775.808

            // ulong.MaxValue // hover over and u get 18.446.744.073.709.551.615
            // ulong.MinValue // hover over and u get 0

            // Error, Cannot implicitly convert type 'double' to 'int'
            // int x = 5.5;

            int x = (int)5.99999; // Explicit typecasting
            Console.WriteLine(x); // returns a 5, everything after the decimal point
                                  // will be droped, so risk of, lose of information

            // this is no problem
            double y = 5; // implicit conversion to a double



        }
    }
}
