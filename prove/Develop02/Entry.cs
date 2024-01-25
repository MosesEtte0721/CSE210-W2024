public class Entry {
    public string _date;
    public string _promptText;
    public string _entryText;


    public string DateAndTime()
    {
        DateTime dateTime = DateTime.Now;
        _date = dateTime.ToShortDateString();
        return _date;
    }


    public void Display()
    {
        Console.WriteLine($"{_date},{_promptText}, {_entryText}");

    }


}