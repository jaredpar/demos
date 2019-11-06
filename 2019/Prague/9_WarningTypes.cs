
class WarningKinds
{
    enum Color
    {
        Red,
        Blue,
        Green
    }

    string ConvertToCode(Color color)
    {
        string code = null;
        switch (color)
        {
            case Color.Red:
                code = "#ff0000";
                break;
            case Color.Blue:
                code = "#0000ff";
                break;
        }

        return code;
    }
}

