using System;

public class EternalGoal: Goal
{

    private int _numberOfTimesCompleted;
    private int _bonus;
    public EternalGoal(string shortName, string description, string points, int bonus): base(shortName, description, points)
    {
        this._numberOfTimesCompleted = 0;
        this._bonus = bonus;
    }

      public override void RecordEvent()
    {
        _numberOfTimesCompleted++;
        Console.WriteLine(_numberOfTimesCompleted);
    }

    public override string GetStringRepresentation()
    {
        return $"{this._shortName},{this._description},{this._points},{this._numberOfTimesCompleted}";
    }

    public override bool IsComplete()
    {
        return true;
    }
}