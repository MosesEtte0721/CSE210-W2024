using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
    **** This class creates method to read and retrieve random scriptures information from a file******
    THIS IS PART OF THE STRETCH TASK OF THE ASSIGNMENT
*/
public class RetrieveFile 
{
    private Dictionary<string, string> _randomScriptures = new Dictionary<string, string>();

    public void LoadFile()
    {
        string fileName = "scriptures.txt";

        string[] ReadAllFiles = File.ReadAllLines(fileName);

        foreach(var word in ReadAllFiles)
        {
            string[] splitWords = word.Split("-");
            string indexZero = splitWords[0];
            string indexOne = splitWords[1];
            _randomScriptures.Add(indexZero, indexOne); 
            
        }
    }


    public KeyValuePair<string, string> DisplayRandom()

    {
        Random random = new Random();
        int listCount = _randomScriptures.Count;
        int randomIndex = random.Next(0,listCount);

        return _randomScriptures.ElementAt(randomIndex);
    }
}