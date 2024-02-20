public class MathAssignment: Assignment
{
    private int _section;
    private string _problems;
    public MathAssignment(string studentName, string topic, int section, string problem): base(studentName, topic)
    {
        this._section = section;
        this._problems = problem;
    }

    public void getHomeWorkList()
    {
        base.getStudentName();
        // Console.WriteLine($"{this.getStudentName()}- topic: {this.getTopic()}");
        Console.WriteLine($"Section: {this._section}, Problem: {this._problems}");
    }
}
