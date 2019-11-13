#nullable enable
using static System.Console;

class BetterName
{
    public string First;
    public string Middle;
    public string Last;

    public BetterName(string first, string middle, string last)
    {
        First = first;
        Middle = middle;
        Last = last;
    }

    public BetterName(string first, string last) :
        this(first, middle: null, last)
    {
    }
}

// 34:30 - 1
