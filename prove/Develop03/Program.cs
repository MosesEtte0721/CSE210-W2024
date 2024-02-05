using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Respond by typing 1 OR 2 ");
        Console.WriteLine("1 Do you want to memorize a random scripture? ");
        Console.WriteLine("2 Do you want to paste or type your personal scripture to memorize? ");
        int input;
        int.TryParse(Console.ReadLine(), out input);
        Console.WriteLine();

        if(input == 1)
        {

            Console.Clear(); // clears the console
            Console.WriteLine("HIDING RANDOM NUMBER: ");
            RetrieveFile loadFile = new RetrieveFile(); // instance of the retrieved file class
            // calls the loadFile method of the retrieve file class
            loadFile.LoadFile();
            // gets the key and value of the stored files
            KeyValuePair<string, string> _scripturesRef  = loadFile.DisplayRandom();
                // get the key 
                string reference = _scripturesRef.Key;
                // get the value
                string scripts = _scripturesRef.Value;
                //  instantiate the scripture class
            Scripture scripture = new Scripture(reference, scripts);
            // calls the display method of the scripture class
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Hit the ENTER key on your keyboard to hide some words: ");
            // gets the user's input
            string hit = Console.ReadLine();
            Console.WriteLine();
            bool variable = true;

            // 
            while (variable)

            {
                // clear the console on each loop 
                Console.Clear();
                // checks if the user press the ENTER key 
                if(hit == "")
                {
                    // hide a given number of random words
                    scripture.HideRandomWords(2);
                    // displays the random words
                    Console.WriteLine(scripture.GetDisplayText());

                    Console.WriteLine();
                        Console.WriteLine("Hit the ENTER key on your keyboard to hide some words: ");
                        hit = Console.ReadLine();

                }
                else if(hit == "quit") // quits the program if the user types quit
                {
                    variable = false;
                    break;
                }
                // val return TRUE if both scriptures are not completely hidden and return FALSE if all words or scriptures are completely hidden
                variable = !scripture.IsCompletelyHidden();
                

            }
        
        }
        else if(input == 2)
        {
            Console.Clear(); // clear the console

            Console.WriteLine();
            
            Console.WriteLine("ENTER THE DETAILS OF SCRIPTURE YOU WANT TO PERSONALIZE below: ");
            Console.WriteLine("Paste the book (of the scripture): ");
                    string book = Console.ReadLine();
                    Console.WriteLine();

            Console.WriteLine("Paste OR type the chapter of the book: ");
                    int chapter;
                    int.TryParse(Console.ReadLine(), out chapter);

            Console.WriteLine("Paste OR type the starting verse of the chapter: ");
                    int startVerse;
                    int.TryParse(Console.ReadLine(), out startVerse);



            Console.WriteLine("Paste OR type the ending verse of the chapter: ");
                    int endVerse;
                    int.TryParse(Console.ReadLine(), out endVerse);
                    Console.WriteLine();

            Console.WriteLine("Paste the scripture text: ");
                    string scriptureText = Console.ReadLine();
                    Console.WriteLine();

            Console.WriteLine("TYPE ONLY DIGITS: ");
                    Console.WriteLine("How many words do you want to hide? ");
                    int randomWordsToHide;
                    int.TryParse(Console.ReadLine(), out randomWordsToHide);



        
            Reference reference = new Reference(book, chapter, startVerse, endVerse);

            Scripture scripture = new Scripture(reference.GetDisplayText(), scriptureText);

            Console.WriteLine("Hit the ENTER on your computer to hide some words: ");
            string variable = Console.ReadLine();
            
            bool val = true;

            while(val)
            {
                Console.Clear(); // clear the console
                if( variable == "")
                {
                
                    scripture.HideRandomWords(randomWordsToHide); // hide to words every time the ENTER key is pressed
                    
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine();

                    Console.WriteLine("Hit the ENTER on your computer to hide some words: ");
                    variable = Console.ReadLine();

                    
                }
                else if (variable == "quit" )
                {
                    val = false;
                    // break;
                }
            // val return TRUE if both scriptures are not completely hidden and return FALSE if all words or scriptures are completely hidden

                else if(!scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("Thank you for memorizing the scripture with us!");
                    break;
                }
            }   

        }

        
        

    }
        
        
    

}