using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction oneOne = new Fraction();
        Fraction topFive = new Fraction(5);
        Fraction topBottom = new Fraction(5,5);

        // oneOne.GetTop();
        Console.WriteLine($"{oneOne.GetFractionString()}");
        Console.WriteLine($"{oneOne.GetDecimalValue()}");
        Console.WriteLine();

        // topFive.GetTop();
        Console.WriteLine($"{topFive.GetFractionString()}");
        Console.WriteLine($"{topFive.GetDecimalValue()}");
        Console.WriteLine();

        
        topBottom.SetBottom(3);
        topBottom.SetTop(19);
        topBottom.GetTop();
        Console.WriteLine($"{topBottom.GetFractionString()}");
        Console.WriteLine($"{topBottom.GetDecimalValue()}");



    }
}