#nullable enable
using System.Collections.Generic;

class Annotations
{
    void Example()
    {
        // non-nullable string
        string nonNullableString;

        // nullable string
        string? nullableString;

        // non-nullable List<T> which contains 
        // non-nullable string values
        List<string> list = new List<string>();
    }

    void UseDisallowNull(string s) { }

    void UseAllowNull(string? s) { }
}
