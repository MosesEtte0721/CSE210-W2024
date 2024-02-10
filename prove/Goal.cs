using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description,string points)
    {
        this._shortName = shortName;
        this._description = description;
        this._points = points;
    }

    public void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public string GetDetailString()
    {
        return "";

    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}