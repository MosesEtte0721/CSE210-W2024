using System;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus):base(shortName,description, points)
    {
        this._target = target;
        this._bonus = bonus;
        this._amountCompleted = 0;

    }

      public override void RecordEvent()
    {
        this._amountCompleted++;
        // Console.WriteLine(this._amountCompleted);
        // return this._amountCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"\nName of Goal:{this._shortName}, Desc:{this._description}, Points: {this._points}, Target: {this._target}, Bonus: {this._bonus}, AmountCompleted: {this._amountCompleted}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailString()
    {
        return $"\n[ ] {this._shortName}, ({this._description}), {this._points}, ----Currently completed: {0}/{this._target}";
    }
}