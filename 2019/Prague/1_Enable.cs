using System;
using System.Collections.Generic;

enum WidgetKind
{
    Shiny,
    Dull,
    New,
}

class Widget
{
    public string Id;
    public string Description;
    public WidgetKind Kind;
    public int Cost;
}

class WidgetFactory
{
    Dictionary<string, Widget> _map = new Dictionary<string, Widget>();

    Widget GetOrCreate(string id, WidgetKind kind)
    {
        Widget widget;
        if (_map.TryGetValue(id, out widget))
        {
            return widget;
        }

        switch (kind)
        {
            case WidgetKind.Dull:
                widget = new Widget() { Kind = WidgetKind.Dull, Cost = 42 };
                break;
            case WidgetKind.Shiny:
                widget = new Widget() { Kind = WidgetKind.Dull, Cost = 13 };
                break;
        }

        return widget;
    }
}

