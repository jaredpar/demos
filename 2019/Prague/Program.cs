using System;
using System.Collections.Generic;
#nullable enable

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = GetIt();
            s ??= "";
            s.ToLower();
        }

        static string? GetIt() => null;

#pragma warning disable 168
        static void Example()
    {
// non-nullable string
string s1;

// nullable string
string? s2;

// non-nullable List<T> which contains nullable string values
List<string?> list;

    }

}


