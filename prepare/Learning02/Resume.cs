using System.ComponentModel.DataAnnotations;

public class Resume {
    public string _personName;
    public List <Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{_personName}");
        Console.WriteLine("Jobs: ");
        foreach(Job i in _jobs)
        {
            i.Display();
        }
    }
}