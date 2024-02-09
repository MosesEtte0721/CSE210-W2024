using System;
using System.ComponentModel;

public class ReflectingAssignment: Activity
{
    private  List<string> _prompts;
    private List<string> _questions = new List<string>();



    public ReflectingAssignment(string name, string decription, int duration): base(name, decription, duration)
    {
       
    }

    private void AddToPrompts()
    {
        _prompts = new List<string>();
        this._prompts.Add("Think of a time when you stood up for someone else");
        this._prompts.Add("Think of a time when you did something really difficult");
        this._prompts.Add("Think of a time when you helped someone in need.");
        this._prompts.Add("Think of a time when you did something truly selfless.");
        
    }

    private void AddToQuestions()
    {
        // this._questions = ;
        this._questions.Add("Why was this experience meaningful to you? ");
        this._questions.Add("Have you ever done anything like this before? ");
        this._questions.Add("How did you get started? ");
        this._questions.Add("How did you feel when it was complete? ");
        this._questions.Add("What made this time different than other times when you were not as successful? ");
        this._questions.Add("What is your favorite thing about this experience? ");
        this._questions.Add("What could you learn from this experience that applies to other situations? ");
        this._questions.Add("What did you learn about yourself through this experience? ");
        this._questions.Add("How can you keep this experience in mind in the future? ");
    }
    
  

// Select and return a random prompt
    public string GetRandomPrompt()
    {
        this.AddToPrompts();
        List<string> previousRandom = new List<string>();
        Random random = new Random();
        // count the total question in the list
        int totalPrompt = this._prompts.Count();
        // get a random index of the questions
        int randomIndex = random.Next(totalPrompt); 
        // select random question based on the random Index
        string getRandomPrompt = this._prompts[randomIndex];
        while(previousRandom.Contains(getRandomPrompt))
        {
            randomIndex = random.Next(totalPrompt);
            getRandomPrompt = this._prompts[randomIndex];
        }
        previousRandom.Add(getRandomPrompt);
    
        return $"{getRandomPrompt.ToUpper() }";
    }

// Select and return a random question
    public string getRandomQuestion()
    {
        List<string> previousQuestions = new List<string>();
        this.AddToQuestions();
        Random random = new Random();
        // count the total question in the list
        int totalQuestions = this._questions.Count();
        // get a random index of the questions
        int randomIndex = random.Next(1, totalQuestions); 
        // select random question based on the random Index
        string randomQuestion = this._questions[randomIndex];

        // checks if the random question is already in a list,
        while(previousQuestions.Contains(randomQuestion))
        {
            // generate new random question if the current question was already selected
            randomIndex = random.Next(1, totalQuestions);
            // get the index of the newly generated item in the list
            randomQuestion = this._questions[randomIndex];
        }
        previousQuestions.Add(randomQuestion);
    
        return $"{randomQuestion.ToUpper() }";
    }

// Print or display all the prompts in the list
    public void DisplayPrompt()
    {
        this.GetRandomPrompt();
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }

// Print all the question in the list
    public void DisplayQuestion()
    {
        this.getRandomQuestion();

            // DateTime dateTime = DateTime.Now;
            // DateTime endTime = dateTime.AddSeconds(900);
                foreach (var question in _questions)
                {
                    Console.Write($"\n > {question } " );
                    
                }    
             
    }

     public void Run()
    {
        this.DisplayStartingMessage();
        int duration = this.GetDuration();
        DateTime dateTime = DateTime.Now;
        DateTime endTime = dateTime.AddSeconds(duration); 

        Console.Write($"Get ready... ");
        this.ShowSpinner();
        Console.WriteLine("\nConsider the following Prompt: \n");
        Console.WriteLine($"  ----{this.GetRandomPrompt()}----"); // Collect and display a random prompt
        Console.WriteLine("    When you have something in mind, press ENTER key to continue: ");
         Console.Write(">>  ");
        string enterKey = Console.ReadLine(); // Collect user input
        Console.WriteLine();
        Console.WriteLine("Now ponder on the following question as they are related to this experience.");
        Console.Write("Your may begin in... ");
        this.ShowCountDown();
        
        // Select a random question when the ENTER key is pressed
        if(enterKey == "")
        {  
                
                while(DateTime.Now < endTime) // execute the code in the block within the stipulated time
                {
                    string randomQuestion = this.getRandomQuestion(); // produce different random question on every loop
                    
                    Console.Write($"\n> {randomQuestion } " ); // print the random question
                    this.ShowSpinner();
                
                }
                
        }
        // Display a message when the stipulated time has elapsed
        if(DateTime.Now >= endTime) 
        {
            Console.WriteLine("\nWell done! ");
            Console.WriteLine("Your session has expired ");
            
        }
        // Display a message at the end of the program
        this.DisplayEndingMessage();     
        
    }
}