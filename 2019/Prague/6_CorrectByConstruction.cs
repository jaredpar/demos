#nullable enable
using System;

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
        bool isNonNull = o is object;
        if (isNonNull)
        {
            o.ToString();
        }

        bool isString = o is string;
        if (isString)
        {
            string str = (string)o;
            str.GetHashCode();
        }
    }
}
