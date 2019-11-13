#nullable enable
using System;
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
        Console.WriteLine($"Name is {address.Name}");
        Console.WriteLine($"Lives on {address.Street}");
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

