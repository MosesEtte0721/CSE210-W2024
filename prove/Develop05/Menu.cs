using System;
public class Menu
{
    private List<string> _menuList = new List<string>{
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load",
        "Record an Event",
        "Quite"
    };

    private List<string> _goalList = new List<string>{
        "Check List",
        "Eternal Goal",
        "Simple Goal"
    };

   

    public int DisplayMenuList()
    {
        
        for(var i =0; i < _menuList.Count; i++)
        {
            Console.WriteLine($"({i+1}). {_menuList[i]}");
        }

        int num;
        Console.Write("Select a choice from the menu (Type number only): ");
        Console.Write(">> ");
        int.TryParse(Console.ReadLine(), out num);
        return num;
    }

    public void DisplayGoalList()
    {
        for(var x = 0; x < this._goalList.Count; x++)
        {
            Console.WriteLine($"({x+1}). {this._goalList[x]}");

        }
        
    }

 
}