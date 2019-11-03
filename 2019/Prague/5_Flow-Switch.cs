#nullable enable
using System;
using static System.Console;

class Swicthy
{
    void PrintAsNumber(object? data)
    {
        switch (data)
        {
            case string s:
                WriteLine(int.Parse(s));
                break;
            case int i:
                WriteLine(i);
                break;
            case null:
                WriteLine("(null)");
                break;
            case var v:
                WriteLine(v.GetHashCode());
                break;
        }

        data.ToString();
    }
}

