using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter scores: ");
        int input = int.Parse(Console.ReadLine());
        if (input >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (input >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (input >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (input >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (input < 60)
        {
            Console.WriteLine("Your grade is F");
        }


    }
}