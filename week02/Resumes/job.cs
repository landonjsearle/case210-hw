public class Job
{
    public String __company;
    public String __jobTitle;
    public int __startYear;
    public int __endYear;

    public void Display()
    {
        Console.WriteLine($"Company: {__company}");
        Console.WriteLine($"Job Title: {__jobTitle}");
        Console.WriteLine($"Work Term: {__startYear}-{__endYear}");
    }
}