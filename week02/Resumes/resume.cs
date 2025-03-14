public class Resume
{
    public String __name;
    public List<Job> __jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {__name}");
        Console.WriteLine($"Jobs:");

        for (int i = 0; i < __jobs.Count; i++)
        {
            __jobs[i].Display();

            if (i != __jobs.Count - 1)
            {
                Console.WriteLine("");
            }
        }
    }

}