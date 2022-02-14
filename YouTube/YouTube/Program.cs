using System;
using System.Collections.Generic;

namespace YouTube // a namespace - used for organizatiion
{
    class Program // a class - has members (Such as a method)
    {
        static void Main(string[] args) // a method - contains a block of code
            // uses a static method, instead of an instance method, static methods dont have
            // to be created with use of the,
            // example: Object object = new object(), new keyword
            // String[] args is an argument and also args is called a parameter of type
            // string Array
            
        // Error, Program does not contain a static 'Main' method suitable for an entry point
        //static void main(string[] args) // lowercase main io Main
        {
            List<int> list;

            // System.Console.WriteLine(); // fully qualified name
            // System.Console. -> intellisence, see show only events, properties and methods,
            // to see what icon stands for what
            // WriteLine() is a static method but also a member of Console or System.Console

            // Console.WriteLine("Hello World!"); // "Hello world!" is an argument passed
            // on to the method

            Object test = new object(); // instance method, not static
            test.GetType(); // instance method: GetType() only accessible from the instance
                            // test

            Object test2 = new object(); // instance method
            Object.Equals(test, test2); // static method: Equals() directly accessible from
                                        // the class name Object and then the .(dot)

            // Error, Can not create an instance of the static class Console
            // Console console = new Console();

            //Console.WriteLine("Hello World!"); // a statement
            //Console.WriteLine("Best friend!"); // a statement

            Program myProgram = new Program(); // Instantiate an instance of class Program
                                               // with the name of myProgram, call the
                                               // Constructor with the new keyword,
                                               // new Program(), to access the Print() method
            myProgram.Print(); // invoke the Print method, using the instance name myProgram

        }

        void Print() // void doesn't return anything, and this is an instance method
        {
            System.Console.WriteLine("Hey!"); // "Hey!" is an argument of type string, and
                                              // the string argument is a parameter of the
                                              // WriteLine() method

            Console.WriteLine("Hello World!"); // a statement
            Console.WriteLine("Best friend!"); // a statement
        }

    }
}

// namespace -> classes -> members -> method -> statements

// create the method
// invoke the method (), like Console.WriteLine(), invoked by use of the ()
// Main is automatically invoked