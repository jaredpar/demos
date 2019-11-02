#nullable enable

using System.Collections.Generic;

class Annotations
{
    void Example()
    {
        // non-nullable string
        string s1;

        // nullable string
        string? s2;

        // non-nullable List<T> which contains 
        //nullable string values
        List<string?> list = new List<string?>();
    }
}
