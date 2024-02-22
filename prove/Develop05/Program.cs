using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Menu menu = new Menu();
        

        List<Goal> goals = new List<Goal>();
        
       Console.WriteLine();
            menu.DisplayMenuList();
            Console.WriteLine("What would you like to do ? ");
            Console.Write(">> ");
        int choose;
        int.TryParse(Console.ReadLine(), out choose);
        while(true)
        {
            if(choose == 1)
            {
                Console.WriteLine();
                menu.DisplayGoalList();
                Console.WriteLine("Which Goal do you wish to set? ");
                Console.Write("\n>> ");
                int goal;
                int.TryParse(Console.ReadLine(), out goal);
                if(goal == 1)
                {
                    Console.WriteLine("\nWhat is the name your goal? ");
                    Console.Write(">> ");
                    string name = Console.ReadLine();


                    Console.WriteLine("What is the short description of your goal? ");
                    Console.Write(">> ");
                    string description = Console.ReadLine();


                    Console.WriteLine("What is the point associating with your goal? ");
                    Console.Write(">> ");
                    string points = Console.ReadLine();

                    SimpleGoal simpleGoal =  new SimpleGoal(name, description, points);
                    simpleGoal.GetDetailString();
                    goals.Add(simpleGoal);
         
                }
                 else if(goal == 2)
                {
                    Console.WriteLine("What is the name your goal? ");
                    Console.Write(">> ");
                    string name = Console.ReadLine(); 


                    Console.WriteLine("What is the short description of your goal? ");
                    Console.Write(">> ");
                    string description = Console.ReadLine();


                    Console.WriteLine("What is the point associating with your goal? ");
                    Console.Write(">> ");
                    string points = Console.ReadLine();


                    Console.WriteLine("What is the bonus when this goal is completed ");
                    Console.Write(">> ");
                    int bonus;
                    int.TryParse(Console.ReadLine(), out bonus);

                    EternalGoal eGoal = new EternalGoal(name, description, points, bonus);
                    eGoal.GetDetailString();
                    goals.Add(eGoal);
                }
                else if(goal == 3)
                {
                    Console.WriteLine("What is the name your goal? ");
                    Console.Write(">> ");
                    string name = Console.ReadLine(); 


                    Console.WriteLine("What is the short description of your goal? ");
                    Console.Write(">> ");
                    string description = Console.ReadLine();


                    Console.WriteLine("What is the point associating with your goal? ");
                    Console.Write(">> ");
                    string points = Console.ReadLine();


                    Console.WriteLine("What is the bonus when this goal is completed ");
                    Console.Write(">> ");
                    int bonus;
                    int.TryParse(Console.ReadLine(), out bonus);

                    Console.WriteLine("What is Your target ");
                    Console.Write(">> ");
                    int target;
                    int.TryParse(Console.ReadLine(), out target);
                    

                    ChecklistGoal checkList = new ChecklistGoal(name, description,points,target,bonus);
                    goals.Add(checkList);


                }

                
            }
            else if(choose == 2)
            {
                foreach(var item in goals)
                {
                    Console.WriteLine(item.GetDetailString());
                }
            }
           

            else if(choose == 6)
            {
                break;
            } 
            else
            {
                if(choose > 6 && choose != 6)
                {
                    Console.WriteLine("Bad inpuType 1 - 5 to make selection and 6 quit");
                }
            }


           Console.WriteLine();
            menu.DisplayMenuList();
            Console.WriteLine("What would you like to do ? \n");
            Console.Write(">> ");
            int.TryParse(Console.ReadLine(), out choose);
        }

    //     Menu menu =  new Menu();
    //     // GoalManager manager = new GoalManager();

    

    

    

    // Console.WriteLine("What is the bonus associating with your goal? ");
    // int bonus;
    // int.TryParse(Console.ReadLine(), out bonus);

    

    // SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
    // EternalGoal eternal = new EternalGoal(name, description, points, bonus);
    // // Goal goal = new Goal();

    // Console.WriteLine(simpleGoal.GetDetailString());
    // Console.WriteLine(eternal.GetStringRepresentation());




       
        
        


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