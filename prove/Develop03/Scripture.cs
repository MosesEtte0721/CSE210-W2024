public class Scripture
{
    private List<Word> _words = new List<Word>(); 
    private string _reference;
    

    public Scripture(string refer, string txt)
    {
        _reference = refer;
        string[] separate = txt.Split(" "); // Turns the the text into an array and each word to list of element

        foreach(var word in separate)
        {
            // loop through every element(every word) in the array and add to the _words list
            Word words = new Word(word);
            _words.Add(words);

        } 

       
        
    }

// Hide random words in the array of words or text provided
    public void HideRandomWords(int num)
    {
        int numOfWords = _words.Count; // count the total number of words in the array
        int numOfWordsToHide = num; // Hide three words at a time
        int numCount = 0; // track hidden words

        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                // track hidden words
                numCount++;
            }
        }


        if(numCount > numOfWordsToHide)
        {
            List<int> randomNums = new List<int>();

            for(int i = 0; i < numOfWordsToHide; i++)
            {
                Random randomNum = new Random(); // 

                //generate random number from the total number of words in the array or text
                int randomIndex = randomNum.Next(numOfWords); 

                // check to make sure random index is not already hidden
                while (_words[randomIndex].IsHidden())
                {
                    randomIndex = randomNum.Next(numOfWords);
                }
                // hide the words at random index
                _words[randomIndex].Hide();
                randomNums.Add(randomIndex); // add the hidden indices or words to a list

            } 
                       
        }
        else
            {// hide all other words in word object
                for(int i = 0; i<numOfWords; i++)
                {
                    if(!_words[i].IsHidden())
                    {
                        _words[i].Hide();
                    }
                }
            }


    }

    public string GetDisplayText()
    {
        List<string> textString = new List<string>();
        textString.Add(_reference);
        
        string hiddenWord = "";

        foreach (Word words in _words)
        {
            if(words.IsHidden())
            {
                int len = words.DisplayText().Count();
                

                for(int i = 0; i < len; i++)
                {
                    hiddenWord += "_";
                }

                textString.Add(hiddenWord);
            }
            else {
                textString.Add(words.DisplayText());
            }
            
        }
        return  $" {string.Join(" ", textString)}";
    }
    

    public bool IsCompletelyHidden()
    {
        bool truthy = true;
        foreach (Word word in _words)
        {
            
            if(!word.IsHidden())
            {
                truthy = false;
                // break;
            }

        }
        return truthy;
    }
}