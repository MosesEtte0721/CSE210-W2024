using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine();

        DisplayResult();

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
        Console.WriteLine();

    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");// prompt for the username
        string userName = Console.ReadLine();
        Console.WriteLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favourite number (an integer): "); // prompt for a number
        int userNumber;
        // converts the user input to an integer
        int.TryParse(Console.ReadLine(), out userNumber);
        Console.WriteLine();
        return userNumber;
    }

    static int SquaredNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult()
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        Console.WriteLine($"{userName}, the square of your number is: {SquaredNumber(userNumber)}");
    }
}