using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
// first name prompt
        Console.Write("What is your First Name? ");
        string firstName =  Console.ReadLine();
// last name prompt
        Console.Write("What is your Last Name ");
        string lastName = Console.ReadLine();
        

        if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
        {
            Console.WriteLine("Empty. Please enter your name");
        }
        else
        {
    
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        }
         


    }
}