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
        
        if (lastName.Length == 0 || firstName.Length == 0)
        {
            Console.WriteLine("Empty. Please enter Name");
        } else {
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        }


    }
}