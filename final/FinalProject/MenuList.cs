using System;
public class MenuList
{

    // private double _period;
    private List<string> _menuList = new List<string>{
        "Check In a Customer",
        "View Customer's feedback on Their Experience",
        "Save Feedback to a File",
        "Retrieve Feedback From a File",
        "Quit".ToUpper()
    };

    public void DisplayMenuList()
    {
        for(var x = 0; x < this._menuList.Count; x++)
        {
            Console.WriteLine($"{x + 1}. {this._menuList[x]}");
        }
    }

    public void ShowSpinner(double param)
    {
         List<string> spin = new List<string>{"|","/","-","\\","|","/","-","\\","|" };
        
        DateTime dateTime = DateTime.Now;
        DateTime futureDateAndTime =  dateTime.AddSeconds(param);
        Console.WriteLine();

        if(dateTime < futureDateAndTime)
        {
            for(int i = 0; i < spin.Count; i++)
        {
            // Console.Clear();
            Console.Write($"{spin[i]}");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        }
       
    }

}