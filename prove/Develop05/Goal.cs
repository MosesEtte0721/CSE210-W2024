using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName, string description,string points)
    {
        this._shortName = shortName;
        this._description = description;
        this._points = points;
    }

    public abstract void RecordEvent();
   

    public abstract bool IsComplete();
    

    public virtual string GetDetailString()
    {   
        return $"[] {this._shortName}, {this._description}, {this._points}";

    }

   

    public abstract string GetStringRepresentation();
    // {
    //     return $"NAME: {this._shortName}, DESC: {this._description}, POINTS: {this._points}";
    // }
}