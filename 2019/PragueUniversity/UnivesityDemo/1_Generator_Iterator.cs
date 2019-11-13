using System;
using System.Collections;
using System.Collections.Generic;

class Iterator
{
    static IEnumerable<int> DoubleValues(IEnumerable<int> enumerable)
    {
        foreach (var item in enumerable)
        {
            yield return item * 2;
        }
    }
}
