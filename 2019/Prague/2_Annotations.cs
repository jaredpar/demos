#nullable enable
using System.Collections.Generic;

class Annotations
{
    void DisallowNull(string s) { }
    void AllowNull(string? s) { }

    void Example(string str)
    {
        DisallowNull(str);
        AllowNull(str);
        str.ToString();
        str = null;
    }

    void ExampleGeneric(List<string> list)
    {
        list[0] = "";
        list[0] = null;
        list[0].GetHashCode();
        AllowNull(list[0]);
        DisallowNull(list[0]);
        list = new List<string>();
    }
}

// 18:00 - 3
// annotatiotns, null forgiving
