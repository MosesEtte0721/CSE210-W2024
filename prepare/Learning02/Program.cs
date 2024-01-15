using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        Job job1 = new Job(); // create new instance of Job

        job1._jobTitle = "Web Developer";
        job1._company = "Andela international";
        job1._startYear = 2021;
        job1._endYear = 2029;

        job1.Display();
        Console.WriteLine();

        Job job2 = new Job(); // create new instance of Job
        job2._jobTitle = "Backend Developer";
        job2._company = "Amazon Inc";
        job2._startYear = 2012;
        job2._endYear = 2017;

        job2.Display();

        Resume resume1 = new Resume(); // create new instance of Resume
        resume1._personName = "Moses Ette";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();



    }
}