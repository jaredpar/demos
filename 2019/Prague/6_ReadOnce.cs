#nullable enable
using static System.Console;

class ReadValuesOnlyOnce
{
    void ModernCSharp(object? obj)
    {
        if (obj != null)
        {
            obj.ToString();
        }

        bool isString = obj is string;
        bool isName = obj is Name;
        if (isString)
        {
            string str = (string)obj;
            WriteLine(str.Length);
        }
        else if (isName)
        {
            Name name = (Name)obj;
            WriteLine(name.First.Length);
            WriteLine(name.Middle.Length);
            WriteLine(name.Last.Length);
        }
    }
}

// 32:15 - 2:15
