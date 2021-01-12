using System;
using System.Collections.Generic;
using System.Text;

namespace Git_Basics
{
    class Account
    {
        public string Email { get; set; }
        public string Passwort { get; set; }

        public Account(string email, string passwort)
        {
            Email = email;
            Passwort = passwort;
        }
    }
}
