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
        Console.WriteLine();

        if(dateTime < futureDateAndTime)
        {
            for(int i = 0; i < spin.Count; i++)
        {
            // Console.Clear();
            Console.Write($"{spin[i]}");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
        }
       
        
    }

    public void ShowCountDown()
    {

        
       for(var  i = 5; i >= 0; i--)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       }
    }
}