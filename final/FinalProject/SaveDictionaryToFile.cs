using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SaveDictionaryToFile
{
   
    public  void SaveDictionary(List<CheckIn> checkin)
    {
        Console.WriteLine("Create Name for the file: ");
        Console.WriteLine(">> ");
        string fileName = Console.ReadLine();
        using (StreamWriter fileSystem = new StreamWriter(fileName))
        {
            foreach (CheckIn check  in checkin)
            {
                 fileSystem.WriteLine(check.SomeFunction());
            }
   
        }
    }
    


}