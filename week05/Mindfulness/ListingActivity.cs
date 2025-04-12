public class ListingActivity : Activity
{
    int _count;
    List<String> _prompts  = new List<String>();

    public ListingActivity()
    {
        _prompts.Add("What are you favorite foods?");
        _prompts.Add("What are the times you felt happy?");
        _prompts.Add("When did you feel the Holy Ghost");

        SetActivtyName("Listing Activity");
        SetDescription("In this activity you will be given a prompt and then will need to write a list of answers to that prompt.\nYou will recive a total count at the end.");
      
        Boolean passed = false;
        do
        {
            Console.Write("How long do you want to do this activity? (seconds) ");
            String line = Console.ReadLine();

            try
            {
                SetDuration(Convert.ToInt16(line));
                passed = true;
            }
            catch (Exception)
            {
                Console.WriteLine("You need to put in a number in seconds!");
            }
        } while (passed == false);
    }

    public void Run()
    {
        Console.WriteLine(GetStartMessage());

        Console.WriteLine($"-----{GetRandomPrompt()}-----");
        Console.WriteLine("Press enter when ready.");
        Console.ReadLine();
        Console.WriteLine("GO!");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You wrote {_count} lines!");
        Console.WriteLine(GetEndMessage());
    }

    public String GetRandomPrompt()
    {
        Random random= new Random();
        return _prompts[random.Next(0, _prompts.Count)];
    }
}