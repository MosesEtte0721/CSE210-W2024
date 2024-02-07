using System;
using System.ComponentModel;

public class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {
        this._name = name;
        this._description = description;
        this._duration = duration;
        
    }

    public void Run()
    {
        
    }
}