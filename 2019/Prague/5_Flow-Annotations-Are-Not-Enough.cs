using System.Collections.Generic;
#nullable enable

class Annotations_Are_Not_Enough
{
    class UserData { }

    Dictionary<string, UserData> _userDataMap = new Dictionary<string, UserData>();

    UserData GetUserData(string? id)
    {
        if (id is null)
        {
            id = GetDefaultId();
        }

        return _userDataMap[id];
    }

    string GetDefaultId() => "Default";
}
