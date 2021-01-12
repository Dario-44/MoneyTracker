using System;
using System.Collections.Generic;
using System.Text;

namespace Git_Basics
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
    }
}
