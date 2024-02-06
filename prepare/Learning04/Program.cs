using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Assignment assignment = new Assignment("Mosest Ette", "Geometry");      
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Obinna Chika", "linear equation", 4, "solve X= -1");
        Console.WriteLine(assignment.GetSummary());
        math.getHomeWorkList();
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("MARY ADAMS", "Creation Myth", "The Story of Creation of the Yorubas in Nigeria ");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.getWritingInformation());
        Console.WriteLine();
    }
}