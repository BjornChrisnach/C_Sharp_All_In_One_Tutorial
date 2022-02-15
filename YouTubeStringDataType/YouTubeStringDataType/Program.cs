using System;

namespace YouTubeStringDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types are stored on the stack, reference types on the heap
            // strings are imutable, they can not be modified, they get replaced by a new copy
            // of a string if you change them

            /*
            string name = "Caleb";
            string name2 = name;
            name += " Curry";

            Console.WriteLine(name); // is the new string "Caleb Curry"
            Console.WriteLine(name2); // is the string "Caleb"
            */

            string name = "Caleb";
            char[] characters = { 'h', 'e', 'l', 'l', 'o' };
            string greeting = new string(characters);
            Console.WriteLine(greeting);

            // interpolation with the $ sign is the most modern way, so the recommended way
            string message = $"Hello my name is {name}, and i like to say {greeting}";
            Console.WriteLine(message);

        }
    }
}
