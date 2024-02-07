using System;
using System.ComponentModel;

public class ReflectingAssignment: Activity
{
    private  List<string> _prompts;
    private List<string> _questions;



    public ReflectingAssignment(string prompts, string _questionis, string name, string decription, int duration): base(name, decription, duration)
    {
       
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        // count the total question in the list
        int totalPrompt = this._prompts.Count();
        // get a random index of the questions
        int randomIndex = random.Next(totalPrompt); 
        // select random question based on the random Index
        string GetRandomPrompt = this._prompts[randomIndex];
    
        return GetRandomPrompt;
    }

    public string getRandomQuestion()
    {
        Random random = new Random();
        // count the total question in the list
        int totalQuestion = this._questions.Count();
        // get a random index of the questions
        int randomIndex = random.Next(totalQuestion); 
        // select random question based on the random Index
        string randomQuestion = this._questions[randomIndex];
    
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }

    public void DisplayQuestion()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
        }
    }
}