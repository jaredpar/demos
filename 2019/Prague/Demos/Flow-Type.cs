#nullable enable
using System;

class StringUtil
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
