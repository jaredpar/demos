using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.IO.MemoryMappedFiles;
using System.Text.Json;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Jared", "Parsons");
            var p2 = new Person("Cecil", "Phillip");

            p1 = p1 with { LastName = "Bome" };
            Console.WriteLine(p1);

            var json = JsonSerializer.Serialize(p1);
            Console.WriteLine(json);
            var p3 = JsonSerializer.Deserialize<Person>(json);
            var isEqual = p1 == p3;
            Console.WriteLine($"Jared instances equal {isEqual}");

            var isEqual2 = p1.Equals(p3);
            Console.WriteLine($"Jared instances equal {isEqual2}");

            var (firstName, lastName) = p2;
            Console.WriteLine($"{lastName}");

            Console.WriteLine($"Cecil in the chat {IsInChat(p2)}");
        }

        static bool IsInChat(Person p) => p switch
        {
            ("Jared", "Parsons") => true,
            ("Cecil", "Phillip") => true,
            _ => false,
        };
    }

    record Person(string FirstName, string LastName);

    /*
    class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public static bool operator ==(Person left, Person right) =>
            left is object ? left.Equals(right) : right is null;

        public static bool operator !=(Person left, Person right) => !(left == right);

        public bool Equals(Person p) =>
            p is object &&
            FirstName == p.FirstName &&
            LastName == p.LastName;

        public override bool Equals(object obj) => obj is Person p && Equals(p);

        public override int GetHashCode() => HashCode.Combine(FirstName, LastName);
    }
    */
}
