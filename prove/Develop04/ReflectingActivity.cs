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
    
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        this.AddToPrompts();
        Random random = new Random();
        // count the total question in the list
        int totalPrompt = this._prompts.Count();
        // get a random index of the questions
        int randomIndex = random.Next(totalPrompt); 
        // select random question based on the random Index
        string GetRandomPrompt = this._prompts[randomIndex];
    
        return $"{GetRandomPrompt.ToUpper() }";
    }

    public string getRandomQuestion()
    {
        this.AddToQuestions();
        Random random = new Random();
        // count the total question in the list
        int totalQuestion = this._questions.Count();
        // get a random index of the questions
        int randomIndex = random.Next(totalQuestion); 
        // select random question based on the random Index
        string randomQuestion = this._questions[randomIndex];
    
        return $"\n{randomQuestion.ToUpper() }";
    }

    public void DisplayPrompt()
    {
        this.GetRandomPrompt();
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }

    public void DisplayQuestion()
    {
        this.getRandomQuestion();

            DateTime dateTime = DateTime.Now;
            DateTime endTime = dateTime.AddSeconds(900);
           
        
            if(DateTime.Now < endTime)
            {
                foreach (var question in _questions)
                {
                    Console.Write($"\n > {question } " );
                    this.ShowSpinner(800);
                }
            }
            else if(DateTime.Now >= endTime)
            {
               
                this.DisplayEndingMessage();
            }
        
      
    }

   
}