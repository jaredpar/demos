using System;
using System.Collections.Generic;
using System.Text;
#nullable enable

class PropretiesAndFields
{
    class UserData { }

    Dictionary<string, UserData> _userDataMap = new Dictionary<string, UserData>();

    UserData GetUserData(string? id)
    {
        if (id is null)
        {
            id = GetDefaultId();
        }

        // Safe now
        return _userDataMap[id];
    }

    string GetDefaultId() => "Default";
}
