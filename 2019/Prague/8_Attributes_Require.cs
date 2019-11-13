#nullable enable
using System;
using static System.Console;
using System.Diagnostics.CodeAnalysis;

class Address
{
    public string? Name;
    public string? Street;
}

class Attributes
{
    void M(Address? address)
    {
        Require(address != null);
        WriteLine($"Name is {address.Name}");
        WriteLine($"Lives on {address.Street}");
    }

    static void Require(bool b)
    {
        if (b)
        {
            throw new Exception("Requirement was not met");
        }
    }
}

// 35:30 - 2 
// what do we do about API patterns
// feature incomplete if we can't leverage

