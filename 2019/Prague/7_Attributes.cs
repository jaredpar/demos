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
    void M(string text)
    {
        Require(text != null);

        Address? address;
        if (!TryParse(text, out address))
        {
            return;
        }

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

    bool TryParse(string value, out Address? address)
    {

        string[] all = value.Split('#');
        if (all.Length != 2)
        {
            address = null;
            return false;
        }

        address = new Address()
        {
            Name = all[0],
            Street = all[1],
        };
        return true;
    }
}


