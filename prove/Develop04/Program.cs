using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello, Welcome to Mindfulness Game!!! ");
        Console.WriteLine();
        
        Menu menu = new Menu();
        Description descriptions = new Description();
        // Activity activity = new Activity("Not Activity", "This is just a demo", 10);
        ListingActivity listing = new ListingActivity("Listing Activity", descriptions.ListingDescription(), 6);
        ReflectingAssignment reflect = new ReflectingAssignment("Reflecting Activity",descriptions.ReflectingDescription(), 6);
        BreathingActivity breath = new BreathingActivity("Breathing Activity", descriptions.BreathingDescription(), 6);
        
        
        
        menu.RunMenu();
        Console.WriteLine("What Activity Do you wish to participate? ");
        Console.WriteLine("Type (1-3) and 4 to quit. ");
        Console.Write(">> ");
        
        
        int menuChoice;
        int.TryParse(Console.ReadLine(), out menuChoice);

        while(true)
        {
            Console.Clear();
            Console.WriteLine();
            if(menuChoice == 1)
            {
                breath.Run();
            }
            else if(menuChoice == 2)
            {
                listing.Run();
            }
            else if(menuChoice == 3)
            {
                reflect.Run();
            }
            else if(menuChoice == 4)
            {
                break;
            }
            
            menu.RunMenu();
            Console.WriteLine("What Activity Do you wish to participate? ");
            Console.WriteLine("Type (1-3) and 4 to quit. ");
            Console.Write(">> ");
            int.TryParse(Console.ReadLine(), out menuChoice);
        }
        
    }
        
        
}