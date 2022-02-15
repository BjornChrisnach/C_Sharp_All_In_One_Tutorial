using System;

namespace YouTubeClassesMethodsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Caleb";
            person.LastName = "Curry";

            //Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.FullName);
        }
    }
}
