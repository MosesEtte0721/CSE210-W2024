using System;

public class ListingActivity: Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>();



    public ListingActivity(string name, string description, int duration): base(name, description, duration)
    {

    }

    private void AddToPrompts()
    {
        this._prompts.Add("\nWho are people that you appreciate? ");
        this._prompts.Add("\nWhat are personal strengths of yours? ");
        this._prompts.Add("\nWho are people that you have helped this week? ");
        this._prompts.Add("\nWhen have you felt the Holy Ghost this month?");
        this._prompts.Add("\nWho are some of your personal heroes? ");
    }
   

    public void GetRandomPrompt()
    {
        this.AddToPrompts();
        Random random = new Random();
        // count the total question in the list
        int totalPrompt = this._prompts.Count();
        // get a random index of the questions
        int randomIndex = random.Next(totalPrompt); 
        // select random question based on the random Index
        string getRandomPrompt = this._prompts[randomIndex];
        Console.WriteLine();
        Console.WriteLine(getRandomPrompt.ToUpper());
        Console.WriteLine();
    }

    
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
       
        this._count = 0;
 
        Console.Write(">> ");
        string userInput = Console.ReadLine();
                
        userList.Add(userInput);
        this._count++;

        return userList;
    }

     public void Run()
    {
        this.DisplayStartingMessage();
        int duration = this.GetDuration();
        DateTime dateTime = DateTime.Now;
        DateTime endTime = dateTime.AddSeconds(duration);
        Console.Write("Get ready... ");
        this.ShowCountDown();
        Console.WriteLine("List as many responses as you can to the following prompt ");
        this.GetRandomPrompt();
        while(DateTime.Now < endTime)
        {
            this.GetListFromUser();
        }
        if(DateTime.Now >= endTime)
        {
            
            Console.WriteLine("\nWell done! ");
            Console.WriteLine("Your session has expired");
        }
        this.ShowSpinner();
        this.DisplayEndingMessage();
        this.ShowSpinner();
    }
}