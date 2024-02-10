using System;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, double points, int target, int bonus):base(shortName,description,points)
    {
        this._target = target;
        this._bonus = bonus;
    }

      public override void RecordEvents()
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

    public override string GetDetailString()
    {
        return "";
    }
}