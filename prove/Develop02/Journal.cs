using System;
using System.Collections.Generic;
using System.IO;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _options = new List<string>();

    

    public void AddToOptions()
    {
        
        string write = "Write ";
        string display= "Display ";
        string save = "Save To File ";
        string load = "Retrieve From File " ;
        string addPrompt = "Add Your Prompt ";
        string quit = "Quit";

        _options.Add(write);
        _options.Add(display);
        _options.Add(save);
        _options.Add(load);
        _options.Add(addPrompt);
        _options.Add(quit);

    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }
    
    public void DisplayMenu()
    {

        for (var i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"{i+1}. { _options[i]}");
        }
        
    }    

    public void DisplayAll()
    {
        foreach (Entry ent in _entries)
        {
            Console.WriteLine($"\nDate: {ent._date}");
            Console.WriteLine($"Prompt: {ent._promptText}");
            Console.WriteLine($"Response: {ent._entryText}");
            Console.WriteLine();
          
        }
    }
    

    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine();
        Console.WriteLine("Saving file ... ");
        Console.Write("Type the name of the file to be saved: ");
        string fileName = Console.ReadLine();
        using(StreamWriter sw = new StreamWriter(fileName))
        {
            foreach(Entry entri in _entries)
            sw.WriteLine($"{entri._date},{entri._promptText},{entri._entryText}");
        }
    }

    public void ReadFromFile()
    {
    // declares an instance of the journal object (gives access to the object)
        Console.WriteLine();
        Console.WriteLine("Retrieving File... "); // tells the user what is happening

        List<Entry> newEntry = new List<Entry>(); //
      

        Console.Write("Type file name: ");
        string fileName = Console.ReadLine(); // prompts for the file to be accessed and read
       
            string[] allLines = File.ReadAllLines(fileName); // read the all lines of of the file 

            foreach (string e in allLines) // looping through each of the file
            {
                string[] sep = e.Split(","); // reading each word in a line that is separated by comma

                Entry entry = new Entry(); // instance of the entry object
                
 // Reassigning string in the entry object to each word on a line  
                entry._date = sep[0]; // first word of every line in the file
                entry._promptText = sep[1]; 
                entry._entryText = sep[2];
                
                this.AddEntry(entry); 

            }

        // DisplayAll(); // displays the new information retrieve from the file
    }

    
    
    
}