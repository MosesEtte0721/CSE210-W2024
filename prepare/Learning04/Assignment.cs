using System;

public class Assignment 
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string getStudentName()
    {
        return _studentName;
    }

    public void setTopic(string param)
    {
        this._topic = param;
    }

    public string getTopic()
    {
        return this._topic;
    }

    public void setStudentName(string param)
    {
        _studentName = param;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}