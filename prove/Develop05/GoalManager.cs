// using System;
// using System.Collections.Generic;

// public class GoalManager
// {
//     private List<Goal> _goals = new List<Goal>();
//     // Goal goals = new Goal();

//     private List<string> _typeOfGoals = new List<string> {
//         "What the name of the new goal",
//         "What is the short description of your goals? ",
//         "What is the amount of point associated with this goal? "

//     };

//     private int _score;
//     private int _numberOfTimes = 0;


//     public GoalManager(Goal goals, int score)
//     {
//         this._goals = goals;
//         this._score = score;
//     }

//     public void DisplayPlayerInfo()
//     {
//         Console.WriteLine("This is your current score: ");
//     }

//     public void AddGoals(Goal goal )
//     {
//         this._goals.Add(goal);
//     }

//     public void Start()
//     {
//         EternalGoal eternal = new EternalGoal();
//     }

//     public void ListGoalNames()
//     {   
//         for(var x = 0; x < this._typeOfGoals.Count; x++)
//         {
            
//             Console.WriteLine($"({x+1}). {this._typeOfGoals[x]}");
           
//         }
 
//     }

//     public void ListGoalDetails()
//     {
//         Console.WriteLine($"This is your current score: ");
        
//     }

//     public void CreateGoal()
//     {

//     }

//     public void RecordEvent()
//     {

//     }

//     public void SaveGoals()
//     {

//     }

//     public void LoadGoals()
//     {
        
//     }
// }