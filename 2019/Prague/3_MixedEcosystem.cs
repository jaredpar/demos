﻿using System;
using System.Collections.Generic;

#nullable disable
class Assembly1
{
    public static object Identity(object o) => o;
}

#nullable enable
class Assembly2
{
    int M()
    {
        object o = Assembly1.Identity(null);
        return o.GetHashCode();
    }
}

// 21:00 - 2
// code with nullability enabled mixing with nullability disabled
