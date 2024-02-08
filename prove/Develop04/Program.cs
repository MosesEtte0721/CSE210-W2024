using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine();
        

        Description descriptions = new Description();
        Activity activity = new Activity("Not Activity", "This is just a demo", 10);
        ListingActivity listing = new ListingActivity("Listing Activity", descriptions.ListingDescription(), 30);
        ReflectingAssignment reflect = new ReflectingAssignment("Reflecting Activity",descriptions.ReflectingDescription(), 6);
        BreathingActivity breath = new BreathingActivity("Breathin Activity", descriptions.BreathingDescription(), 6);
        // listing.Run();
        // breath.Run();
        reflect.Run();
        // breath.DisplayStartingMessage();
        // Console.WriteLine("How long do you to be engaged in the activity? ");
        // Console.Write(">> ");
        // breath.ShowCountDown();
        // breath.ShowSpinner();
        // Console.Write("Breath in...");
        // breath.ShowCountDown();
        // breath.ShowSpinner();
        // Console.Write("Breath out...");
        // breath.ShowCountDown();
        // breath.ShowSpinner();
        // listing.DisplayStartingMessage();
        // Console.WriteLine();
        // // activity.DisplayStartingMessage();
        // Console.WriteLine("Loading prompt... ");
        // listing.ShowCountDown();
        // listing.GetRandomPrompt();
        // listing.GetListFromUser();
        // listing.DisplayEndingMessage();

        // reflect.DisplayStartingMessage();
        // Console.Write("In seconds, How long do you want your session to last?: ");
        // int spinTime;
        // int.TryParse(Console.ReadLine(), out spinTime);
        // 

        
        //
        }
        
        
        
       
       
        

        
    // }
}