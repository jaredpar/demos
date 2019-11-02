using System;
using System.Collections.Generic;
using System.Text;
#nullable enable

class Annotations_Are_Not_Enough
{
    class UserData { }

    Dictionary<string, UserData> _userDataMap;

UserData GetUserData(string? id)
{
    string id2;
    if (id is null)
    {
        id2 = GetDefaultId();
    }
    else
    {
        // Still a warning because assigning 
        // string? to string
        id2 = id;
    }

    // Safe now
    return _userDataMap[id2];
}

    string GetDefaultId()
    {

    }
}
}
