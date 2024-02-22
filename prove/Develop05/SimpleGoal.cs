using System;

public class SimpleGoal: Goal
{
    private bool _isComplete;
    List<Goal> _goals = new List<Goal>();


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
        return $"Name: {this._shortName}, Desc: {this._description}, Points: {this._points}, Target: {this._isComplete} ";
    }

    

    public override bool IsComplete()
    {
        return this._isComplete;
    }

    // public override void AddGoals(Goal _goals)
    // {

    // }
}