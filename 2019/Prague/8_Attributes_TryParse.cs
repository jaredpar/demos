#nullable enable
using System;
using static System.Console;
using System.Diagnostics.CodeAnalysis;

class AttributesTryGet
{
    void M(string text)
    {
        Address? address;
        if (!TryParse(text, out address))
        {
            return;
        }

        WriteLine($"Name is {address.Name}");
        WriteLine($"Lives on {address.Street}");
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

// 37:30 - 1
// collection of other attributes linked in the more resources slide
// [NotNullWhen(returnValue: true)]

