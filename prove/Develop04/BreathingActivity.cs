using System;
using System.ComponentModel;

public class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description, int duration=0): base(name, description, duration)
    {
        this._name = name;
        this._description = description;
        this._duration = duration;
        
    }

    private void Breath(string breath)
    {
        Console.WriteLine(breath);
        
    }
    public void Run()
    {
        this.DisplayStartingMessage();
        int duration = this.GetDuration();
        DateTime dateTime = DateTime.Now;
        DateTime endTime = dateTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            this.ShowCountDown();
            this.ShowSpinner();
            Console.Write("Now Breath out...");
            this.ShowCountDown();
            this.ShowSpinner();
            Console.WriteLine();
            
        }
        if(DateTime.Now >= endTime)
        {
            Console.WriteLine("\nWell done! ");
            Console.WriteLine("Your session has expired\n");
        }
        this.ShowSpinner();
        this.DisplayEndingMessage();
        
    }
}