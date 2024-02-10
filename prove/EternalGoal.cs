using System;

public class EternalGoal: Goal
{

    public EternalGoal(string shortName, string description, string points): base(shortName, description, points)
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