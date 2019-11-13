#nullable enable
using static System.Console;

class Correct
{
    class Name
    {
        public string First;
        public string Middle;
        public string Last;

        public Name(string first, string middle, string last)
        {
            First = first;
            Middle = middle;
            Last = last;
        }

        public Name(string first, string last) :
            this(first, middle: null, last)
        {
        }
    }

    void ByConstruction(object? o)
    {
        o.ToString();

        bool isString = o is string;
        bool isName = o is Name;
        if (isString)
        {
            string str = (string)o;
            WriteLine(str.Length);
        }
        else if (isName)
        {
            Name name = (Name)o;
            WriteLine(name.First.Length);
            WriteLine(name.Middle.Length);
            WriteLine(name.Last.Length);
        }
    }
}

// 32:15 - 2
