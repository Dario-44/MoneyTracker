using System;
using System.Collections.Generic;
using System.Text;

namespace Git_Basics
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
    }
}
