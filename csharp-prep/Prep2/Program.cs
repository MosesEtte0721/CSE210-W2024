using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter scores: ");
        int input = int.Parse(Console.ReadLine());

        string output = "Your grade is ";
        string plus = "+";
        string minus = "-";
        if (input >= 90 && input <= 100)
        {

            if (input >= 90 && input < 95)
            {
                Console.WriteLine($"{output} A{minus}");

            } else {
                Console.WriteLine($"{output}A");

            }


        }

        else if (input >= 80 && input < 90)
        {
            if (input >= 80 && input < 85)
            {
                Console.WriteLine($"{output}B{minus}");
            } else {
                Console.WriteLine($"{output} B{plus}");

            }

        }

        else if (input >= 70 && input < 80)
        {
            if (input >= 70 && input < 75) 
            {
                Console.WriteLine($"{output} C{minus}");
            } else {
                Console.WriteLine("Your grade is C-");

            }

        }

        else if (input >= 60 && input < 70)
        {   
            if (input >= 65)
            {
                Console.WriteLine($"{output} D{plus}");
            } else {
            Console.WriteLine("Your grade is D-");

            }
        }

        else if (input < 60)
        {
            Console.WriteLine($"{output}F");
        }


    }
}