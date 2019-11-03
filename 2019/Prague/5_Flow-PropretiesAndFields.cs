using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
#nullable enable

class PropretiesAndFields
{
    class Person
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string? GetMiddleName() => MiddleName;
    }

    void M(Person p)
    {

    }
}
