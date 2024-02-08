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
        ReflectingAssignment reflect = new ReflectingAssignment("Reflecting Activity",descriptions.ReflectingDescription(), 20);


        // listing.DisplayStartingMessage();
        // Console.WriteLine();
        // // activity.DisplayStartingMessage();
        // Console.WriteLine("Loading prompt... ");
        // listing.ShowCountDown();
        // listing.GetRandomPrompt();
        // listing.GetListFromUser();
        // listing.DisplayEndingMessage();

        reflect.DisplayStartingMessage();
        Console.Write("In seconds, How long do you want your session to last?: ");
        int spinTime;
        int.TryParse(Console.ReadLine(), out spinTime);
        Console.Write($"Get ready... \n");
        reflect.ShowSpinner(spinTime);
        Console.WriteLine("Consider the following Prompt: ");
        Console.WriteLine($"  ---- {reflect.GetRandomPrompt()} ----");

        Console.WriteLine("    When you have something in mind, press ENTER key to continue: ");
        Console.Write(">>  ");
        string enterKey = Console.ReadLine();
        Console.WriteLine();
        if(enterKey == "")
        {
           
            Console.WriteLine("Now ponder on the following question as they are related to this experience.");
            Console.Write("Your may begin in ... ");
            reflect.ShowCountDown();
             reflect.DisplayQuestion();
            
            reflect.ShowSpinner(spinTime);
        }
        
        
        
       
       
        

        
    }
}