#nullable enable
using static System.Console;

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
        WriteLine(p.FirstName.Length);
        WriteLine(p.MiddleName.Length);
        WriteLine(p.LastName.Length);

        WriteLine(p.GetMiddleName().Length);
    }
}

// 27:45 - 2:15
