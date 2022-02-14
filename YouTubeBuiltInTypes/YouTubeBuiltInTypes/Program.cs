using System;

namespace YouTubeBuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Built in types are an alias for the .NET types, both work
            int x = 5; // c# type keyword
            // or
            Int32 y = 5; // .NET type

            string z = "Caleb"; // c# type keyword, hover over and it says class System.String
            // or
            String a = "Caleb"; // .NET type
            
            // All BuiltInTypes on site,
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
            // are value types except for object, string and dynamic -> reference types



        }
    }
}
