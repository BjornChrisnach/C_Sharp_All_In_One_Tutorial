using System;

namespace YouTubeStringPropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Caleb";

            //Console.WriteLine(name.Length); // you can only get the length, you can not set i
            // and it returns an int

            /*
            // CompareTo()
            // displays 0 if its the same position in the sorting order, it would display -1 if the string
            // name precedes "Caleb", it would display 1 if the string name follows after "Caleb"

            Console.WriteLine(name.CompareTo("Baleb")); // displays 1, name follows after "Baleb"
            Console.WriteLine(name.CompareTo("Caleb")); // displays 0, name is at the same position as "Caleb"
            Console.WriteLine(name.CompareTo("Daleb")); // displays -1, name precedes "Daleb"

            // it returns an int
            int position = name.CompareTo("Baleb")
            */

            /*
            bool isEqual = name == "Caleb"; // returns true or false
            Console.WriteLine(isEqual); // displays True
            */

            /*
            // IndexOf()
            string name = "Calaleb";
            int position = name.IndexOf("al"); // displays 1, first found at index 1
            Console.WriteLine(position);

            Console.WriteLine(name.IndexOf("al", 2)); // displays 3, start at index and it was found at
                                                      // index 3
            */

            /*
            // Remove()
            string name = "Calaleb";
            Console.WriteLine(name.Remove(1, 2)); // displays "Caleb", "al" was removed
            */

            /*
            // Trim()
            // removes extra spaces and tabs
            string name = "         \t\t\t\t\tCalaleb        ";
            Console.WriteLine(name.Trim()); // displays "Calaleb"
            */

            // Split()
            // splits a string into substrings, and returns an array of strings
            string name = "Hello my name is Caleb!";
            string[] words = name.Split(' ');
            Console.WriteLine(words[1]); // displays "my";

            // displays on seperate lines: "Hello", "my", "name", "is", "Caleb!"
            foreach ( string sub in name.Split(' '))
            {
                Console.WriteLine(sub);
            }

        }
    }
}
