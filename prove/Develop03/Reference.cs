using System;
using System.Collections.Generic;

public class Reference {
    
    private string _book;
    private int _chapter;
    private int _endVerse;
    private int _startVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if(_endVerse == 0 )
        {
          
            return $"{_book} {_chapter}:{_startVerse}: ";
            
        }
        
        return $"{_book} {_chapter}:{_startVerse} - {_endVerse}: ";
        
    }
}