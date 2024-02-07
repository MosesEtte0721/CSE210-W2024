using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        string listDesc = "This activity will help you reflect on the good things in your life by \n    having you list as many things as you can in a certain area.";
        Console.WriteLine();
        Activity activity = new Activity("Not Activity", "This is just a demo", 10);
        ListingActivity listing = new ListingActivity("Listing Activity", listDesc, 30);

        listing.DisplayStartingMessage();
        Console.WriteLine();
        // activity.DisplayStartingMessage();
        Console.WriteLine("Loading prompt... ");
        listing.ShowCountDown();
        listing.GetRandomPrompt();
        listing.GetListFromUser();
        listing.DisplayEndingMessage();
    }
}