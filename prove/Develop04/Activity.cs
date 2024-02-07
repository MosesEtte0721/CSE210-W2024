using System;
using System.Collections.Generic;


public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        this._name = name;
        this._description = description;
        this._duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {this._name} ");
        Console.WriteLine($"    {_description}");
        // Console.WriteLine(this.GetDuration());

    }

    private int GetDuration()
    {
        Console.WriteLine("How many seconds do you want to spend on this activity? ");
        int duration;
        int.TryParse(Console.ReadLine(), out duration);
        return duration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nThank you for participation in the {this._name}");
    }

    public void ShowSpinner(int seconds)
    {
         List<string> spin = new List<string>{"|","/","-","\\","|","/","-","\\","|" };
        
        DateTime dateTime = DateTime.Now;
        DateTime futureDateAndTime =  dateTime.AddSeconds(10);
        Console.WriteLine("Welcome Onboard");
        Console.WriteLine();

        if(dateTime < futureDateAndTime)
        {
            for(int i = 0; i < spin.Count; i++)
        {
            // Console.Clear();
            Console.Write($"{spin[i]}");
            Thread.Sleep(600);
            Console.Write("\b \b");
        }
        }
        
        Console.WriteLine("Weldone!");
    }

    public void ShowCountDown()
    {
       int num;
       for(num = 5; num > 0; num--)
       {
        Console.Write(num);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       }
    }
}