using System;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points): base(name, description, points)
    {
        
    }

    public void RecordEvents()
    {

    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public override bool IsComplete()
    {
        return false;
    }
}