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
        this._prompts.Add("Who are people that you appreciate? ");
        this._prompts.Add("What are personal strengths of yours? ");
        this._prompts.Add("Who are people that you have helped this week? ");
        this._prompts.Add("When have you felt the Holy Ghost this month?");
        this._prompts.Add("Who are some of your personal heroes? ");
    }
    public void Run()
    {

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
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(this._duration);
        this._count = 0;
        Console.WriteLine("Respond to the Question: ");
        while(true)
        {
            
            if(DateTime.Now < futureTime)
            {
                Console.Write(">> ");
                string userInput = Console.ReadLine();
                
                userList.Add(userInput);
                this._count++;
            }
            
            else if(DateTime.Now >= futureTime)
            {
                Console.WriteLine("\nYour session has expired: ");
                Console.WriteLine($"You have entered {this._count} items");
                break;
            }
            


        }
        return userList;
    }
}