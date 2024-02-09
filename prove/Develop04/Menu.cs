public class Menu 
{
    private List<string> _menu = new List<string>{"Breathing Activity", "Listing Activity","Reflecting Activity", "Exit"};

    private void DisplayMenuOptions()
    {
        int counter = 0;
        foreach(var menu in _menu)
        {
            Console.WriteLine($"{counter++ + 1}). {menu}");
            

        }
    }

    public void RunMenu()
    {
        this.DisplayMenuOptions();
        Console.WriteLine();

    }
}