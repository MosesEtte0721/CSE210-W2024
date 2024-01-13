using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randNumber = new Random();
        int num = randNumber.Next(1, 101);
        Console.WriteLine($"Magic number is: {num}");

        Console.Write("Type the magic number: ");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput > num)
        {
            Console.WriteLine("Guess Lower");
        }
        else if (userInput < num)
        {
            Console.WriteLine("Guess Higher");
        }
        else{
        }

        while (userInput != num)
        {
            if (userInput > num)
            {
                Console.WriteLine("Guess Lower");
            }
            else if (userInput < num)
            {
                Console.WriteLine("Guess Higher");
            }
            Console.Write("What is your guess? ");
            userInput = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Congrats! Your guess is correct");

        

    }
}