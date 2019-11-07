using System;
#nullable enable

class Name
{
    public string First;
    public string? Middle;
    public string Last;

    public Name(string first, string? middle, string last)
    {
        First = first;
        Middle = middle;
        // Last = last;
    }

    public Name(string first, string last) :
        this(first, middle: null, last)
    {
    }
}

class ConstructorUse
{
    void M()
    {
        var name = new Name("Jared", "Parsons");
        var length = 
            name.First.Length + 
            name.Middle.Length +
            name.Last.Length;
        Console.WriteLine(length);
    }
}
