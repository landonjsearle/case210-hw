using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Activity activity = new Activity();

        activity.SetDuration(100);

        activity.ShowSpinner(5);
        activity.ShowCountdown(3);

        BreathingActivity breathingActivity= new BreathingActivity();
        breathingActivity.Run();
    }
}