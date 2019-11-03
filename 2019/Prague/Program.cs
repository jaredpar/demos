using System;
using System.Collections.Generic;

#nullable enable

class Program
{
    static void Main(string[] args)
    {
        string local;
        Console.WriteLine("Hello World!");
        var s = GetIt();
        s ??= "";
        s.ToLower();

        List<string> ss = null;
        List<string?> su = null;
        List<string?>? uu = null;
        List<string>? us = null;

        us = ss;
        su = ss!;
        uu = su;
        us = uu;
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


