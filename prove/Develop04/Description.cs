using System;
using System.Reflection.Metadata.Ecma335;
public class Description
{
    public string ListingDescription()
    {
        string listDesc = "\nThis activity will help you reflect on the good things in your life by \n    having you list as many things as you can in a certain area. \n";
        return listDesc;
    }

    public string ReflectingDescription()
    {
        string ReflectDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. \n    This will help you recognize the power you have and how you can use it in other aspects of your life. \n";
        return ReflectDesc;
    }

    public string BreathingDescription()
    {
        string breathDesc = "\nThis activity will help you relax by walking your through breathing in and out slowly. \n    Clear your mind and focus on your breathing. \n";
        return breathDesc;
    }
}