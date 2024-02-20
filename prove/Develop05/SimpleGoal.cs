using System;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points): base(name, description, points)
    {
        this._isComplete = false;
    }

    public override void RecordEvent()
    {
        this._isComplete = true;
        // return this._isComplete
    }

    public override string GetStringRepresentation()
    {
        return $"{this._shortName}, {this._description}, {this._points},{this._isComplete}";
    }

    

    public override bool IsComplete()
    {
        return this._isComplete;
    }
}