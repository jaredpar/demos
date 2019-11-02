#nullable enable
using System;

class Swicthy
{
    void PrintIt(string? str)
    {
        if (str == null)
        {
            str = "";
        }

        Console.WriteLine($"{str.Length} - {str}");
    }

}


