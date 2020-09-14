﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9
{
    /*
        public static bool operator ==(Person left, Person right) =>
            left is object ? left.Equals(right) : right is null;

        public static bool operator !=(Person left, Person right) => !(left == right);

        public bool Equals(Person p) =>
            p is object &&
            FirstName == p.FirstName &&
            LastName == p.LastName;

        public override bool Equals(object obj) => obj is Person p && Equals(p);

        public override int GetHashCode() => HashCode.Combine(FirstName, LastName);
    */


    /*
    public sealed class Person : IEquatable<Person>
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person WithFirstName(string firstName) => new Person(firstName, LastName);

        public Person WithLastName(string lastName) => new Person(FirstName, lastName);

        public void Deconstruct(out string n1, out string n2)
        {
            n1 = FirstName;
            n2 = LastName;
        }

        public override bool Equals(object obj) => obj is Person p && Equals(p);

        public bool Equals(Person other) =>
            other is object &&
            FirstName == other.FirstName &&
            LastName == other.LastName;

        public override int GetHashCode() => HashCode.Combine(FirstName, LastName);

        public override string ToString() => $"{FirstName} {LastName}";
    }
    */

    public sealed class Point
    {
        public int X { get; init; }
        public int Y { get; init; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}

namespace System.Runtime.CompilerServices
{
    class IsExternalInit { }
}

/*
namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("jared", "parsons");
            var (firstName, lastName) = p;
            Console.WriteLine($"{firstName} {lastName}");

            if (p == new Person("john", "doe"))
            {
                Console.WriteLine("This is John Doe");
            }

            var p2 = p.WithLastName("Bome");
        }

        static bool IsInChat(Person p)
        {
            return p switch
            {
                ("jared", "parsons") => true,
                ("cecil", "phillip") => true,
                _ => false
            };
        }
    }
}
*/
