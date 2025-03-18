public class Entry
{
    public String __entry;
    public String __date;
    public String __prompt;

    public void Display()
    {
        Console.WriteLine($"[{__date}] {__prompt}");
        Console.WriteLine(__entry);
    }
}