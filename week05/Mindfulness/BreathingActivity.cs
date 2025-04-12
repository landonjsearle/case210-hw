public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        base.SetActivtyName("Breathing Activity");
        base.SetDescription("In this activity you will inhale for 4 seconds through your nose, and exhale for mouth for 6 seconds.");
        
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

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        Console.WriteLine("Press enter when you are ready");
        Console.ReadLine(); 

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in: ");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Breath Out: ");
            ShowCountdown(6);
            Console.WriteLine();
        }

        Console.WriteLine(GetEndMessage());
    }
}