using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeIfElse
{
    public class Person
    {
        // string middleName = "Granola Bar"; // field, only accessible from inside the class, private
        public string FirstName { get; set; } // property
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string GetFullName() // method
        {
            return FirstName + " " + LastName;
        }

    }
}
