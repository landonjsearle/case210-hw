using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();

        job1.__jobTitle = "Software Engineer";
        job1.__company = "Microsoft";
        job1.__startYear = 2013;
        job1.__endYear = 2026;
        
        Job job2 = new Job();
        job2.__jobTitle = "Janitor";
        job2.__company = "Apple";
        job2.__startYear = 2002;
        job2.__endYear = 2025;



        Resume resume = new Resume();
        resume.__name = "Landon Searle";
        resume.__jobs.Add(job1);
        resume.__jobs.Add(job2);

        resume.Display();
    }
}