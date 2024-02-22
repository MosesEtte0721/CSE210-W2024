using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SaveDictionaryToFile
{
    
   
    public  void SaveDictionary(List<string> checkin, string fileName)
    {
        
        using (StreamWriter fileSystem = new StreamWriter(fileName))
        {
            foreach(var check  in checkin)
            {
                 fileSystem.WriteLine($"{check}\n");
                Console.WriteLine(check);
                
            }
   
        }
        Console.WriteLine("File saved successfully.");
    }
    


}