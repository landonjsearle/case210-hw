public class ReflectionActivity : Activity
{
    List<String> _prompts = new List<string>();
    List<String> _questions = new List<string>();

    public ReflectionActivity()
    {
        _prompts.Add("Think of your favorite hymes.");
        _prompts.Add("Picture a beutiful sky.");
        _prompts.Add("Think about the Savior.");

        _questions.Add("What are you thinking about?");
        _questions.Add("What is the most important thing about this?");
        _questions.Add("What about this makes you smile?");
        _questions.Add("Are you hungry?");
        _questions.Add("Did you brush your teeth?");
        _questions.Add("Does this make you happy?");

        SetActivtyName("Reflection Activity");
        SetDescription("In this activity you will given a propmt to think about and some questions to guide you");

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

        Console.WriteLine($"You will be using the follow prompt to guide you thinking through a list of questions for {GetDuration()} seconds.");
        Console.WriteLine("Prompt: ");
        DisplayPrompt();
        Console.WriteLine("Press enter when you are ready.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(8);
        }

        Console.WriteLine(GetEndMessage());
    }

    public String GetRandomPrompt()
    {
        Random random= new Random();
        return _prompts[random.Next(0, _prompts.Count)];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"-----{GetRandomPrompt()}------");
    }
    public String GetRandomQuestion()
    {
        Random random= new Random();
        return _questions[random.Next(_questions.Count)];
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}