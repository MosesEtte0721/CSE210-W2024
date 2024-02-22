using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SaveDictionaryToFile
{
    
   
    public  void SaveDictionary(List<string> checkin)
    {
        Console.WriteLine("Create Name for the file: ");
        Console.WriteLine(">> ");
        string fileName = Console.ReadLine();
        using (StreamWriter fileSystem = new StreamWriter(fileName))
        {
            foreach (var check  in checkin)
            {
                 fileSystem.WriteLine($"{check}");
            }
   
        }
        Console.WriteLine("File saved successfully.");
    }
    


}