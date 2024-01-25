using System;

class Program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal game: ");
        
        // Journal entries = new Journal();
        PromptGen prompt = new PromptGen();
       
        Journal journal = new Journal();


        //      Display the menu options for users to choose from  
        journal.AddToOptions();
        journal.DisplayMenu();
        
       
//      Request the user to type a number  
        int resp;
        Console.Write("Type a number to choose (1-5) and 0 to exit: ");

        int.TryParse(Console.ReadLine(), out resp);
        Console.WriteLine();
    
//      Checking for what the user enters
        do
        {

            if(resp == 1)
            {
                Entry entry = new Entry();
                string randomNum = prompt.RandomGen();

                Console.WriteLine(randomNum);

                string ans = Console.ReadLine();
                entry.DateAndTime();

                entry._promptText = randomNum;
                entry._entryText = ans;
                
                journal.AddEntry(entry);
                
            }
            else if(resp == 2)
            {
                journal.DisplayAll();
                
            }
            else if(resp == 3)
            {
                journal.SaveToFile(journal._entries);
            }

            else if(resp == 4)
            {
                Console.WriteLine();
                journal.ReadFromFile();
            }

            else if(resp == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Adding prompt... ");
                
                Console.WriteLine("TYPE and ADD your prompt below: ");
                string newPrompt = Console.ReadLine();

                prompt.AddPersonalPrompt(newPrompt);
                Console.WriteLine("Prompt Successfully Added...");
            }
             else if(resp >= 5 || resp != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Choose a corresponding digit (1 - 5) and 6 to exit ");
            }
            else if(resp == 6) 
            {
                Console.WriteLine("Thank you for taking time to write your journal");
            }

            Console.WriteLine();
            journal.DisplayMenu();

            Console.Write("Type a number to choose (1-5) and 6 to exit: ");
            int.TryParse(Console.ReadLine(), out resp);
           

        } while(resp != 6);

       
            

    }
}