using System;

namespace YouTubeIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Caleb";
            person.LastName = "Curry";

            Console.WriteLine("What do you think the name is?");
            string fullNameGuess = Console.ReadLine();

            Console.WriteLine("Second guess?");
            string fullNameGuess2 = Console.ReadLine();

            // (expression), resolves to True or False, if it's True the if code block gets executed,
            // if it's False the if code block will get bypassed or skipped, it jumps over the code block
            // it could be that it evaluates the next else if and so on, and finally executes the
            // else block, if one is given
            if (person.FullName == fullNameGuess) // person.FullName.Equals("Caleb Curry"), used in Java instead of ==
            {
                Console.WriteLine("You got the name! You win");
            } else if (person.FullName == fullNameGuess2) {
                Console.WriteLine("You got the name! You get 1/2 points");
            }
            else
            {
                Console.WriteLine("You're a dissapointment");
            }

        }
    }
}
