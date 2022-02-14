using System;

namespace YouTubeValueTypesReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types, and also part of the simple types
            /*
            int a = -5; // it directly contains the value, instead of a reference type ->
                        // only holds a reference to whatever you are trying to store
            int b = a; // Copies the value -5 into variable b, if we change b into -10,
                       // a will still hold a value of -5; With reference types a and b would
                       // point to the same value or whatever, and if you change one,
                       // the other one would also change

            Console.WriteLine(a);
            Console.WriteLine(b);

            b = 10;

            Console.WriteLine(a);
            Console.WriteLine(b);
            */

            // Reference types
            /*
            int[] a = { -5 };
            int[] b = a;

            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);

            b[0] = 10;

            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);
            */

            /*
            int[] a = { -5 };
            Test(a);
            Console.WriteLine(a[0]);
            */

            // changes are not reflected in 'a' because we use a copy of the value -5
            // and not a reference
            int a = -5;
            Test(a);
            Console.WriteLine(a);
        }

        /*
        // also uses int[] a as the parameter or argument,
        // but also works with a different identifier, like example int[] x
        //static void Test(int[] a)
        //{
        //    a[0] = 100;
        //}

        // references can be changed inside of methods, so be cautious
        static void Test(int[] x)
        {
            x[0] = 100;
        }
        */

        static void Test(int x)
        {
            x = 100;
        }

    }
}
