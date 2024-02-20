using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Menu menu =  new Menu();
        // GoalManager manager = new GoalManager();

    Console.WriteLine("What is the name your goal? ");
    string name = Console.ReadLine();

    Console.WriteLine("What is the short description of your goal? ");
    string description = Console.ReadLine();

    Console.WriteLine("What is the point associating with your goal? ");
    string points = Console.ReadLine();

    Console.WriteLine("What is the bonus associating with your goal? ");
    int bonus;
    int.TryParse(Console.ReadLine(), out bonus);

    

    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
    EternalGoal eternal = new EternalGoal(name, description, points, bonus);
    // Goal goal = new Goal();

    Console.WriteLine(simpleGoal.GetDetailString());
    Console.WriteLine(eternal.GetStringRepresentation());




       
        
        


    }
}

 // Goal goal 
        // ChecklistGoal checklist = new ChecklistGoal();//ChecklistGoal
    //     int displayMenu = menu.DisplayMenuList();
    //     // string goalList = menu.DisplayGoalList();
    //     Console.WriteLine("W");
       


    //     if (displayMenu == 1)
    //     {
    //        menu.DisplayGoalList();
    //     }

    //     Console.WriteLine("Which Type of Goal would you like to create? ");
    //     Console.Write(">> ");
    //     int num;
    //     int.TryParse(Console.ReadLine(), out num);
    //     if(num == 1)
    //     {
    //         menu.typeOfGoals();
    //     }