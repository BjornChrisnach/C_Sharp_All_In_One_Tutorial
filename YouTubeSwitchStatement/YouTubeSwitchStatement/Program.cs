using System;

namespace YouTubeSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // string example
            string name = "Caleb";
            switch(name)
            {
                case "Caleb":
                    Console.WriteLine("You are so legit");
                    break; // Console.WriteLine("Welcome!"); is executed
                case "Claire":
                    Console.WriteLine("Get the heck away you freak bag");
                    return; // Console.WriteLine("Welcome!"); is not executed
                    //break;
                default:
                    Console.WriteLine("Who are you?");
                    break;
            }
            */

            // int example
            int name = 5;
            switch (name)
            {
                case 3:
                    Console.WriteLine("You are so legit");
                    break; // Console.WriteLine("Welcome!"); is executed
                case 5:
                    Console.WriteLine("Get the heck away you freak bag");
                    return; // Console.WriteLine("Welcome!"); is not executed
                            //break;
                default:
                    Console.WriteLine("Who are you?");
                    break;
            }

            Console.WriteLine("Welcome!");

        }
    }
}
