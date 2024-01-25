using System;
using System.Collections.Generic;
using System.Linq;
public class PromptGen 
{
    public List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    // Entry entry = new Entry();

    
// THIS IS A STRETCH BEYOND REQUIREMENT. it allows the users to personalize prompts
    // Helps users create their personal prompts
    public void AddPersonalPrompt(string para){
        _prompts.Add(para);
    }

    //  Retrieves random prompts from the prompt list
    public string RandomGen()
    {
        // AddPersonalPrompt(entry._promptText);
        Random randomPrompt = new Random();
        
        var rand = randomPrompt.Next(0,_prompts.Count);
      
        return _prompts[rand];
      
     }

    public void DisplayAllPrompts()
    {
        foreach(var prompt in _prompts)
        {
            Console.WriteLine($"{prompt}");
        }
    }
}