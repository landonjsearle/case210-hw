using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> list = new List<Activity>();

        RunningAct runningAct= new RunningAct(DateTime.Now,  30, 10);
        list.Add(runningAct);

        SwimmingAct swimmingAct= new SwimmingAct(DateTime.Now, 60, 5);
        list.Add(swimmingAct);

        BikeAct bikeAct= new BikeAct(DateTime.Now, 120, 15);
        list.Add(bikeAct);

        foreach(Activity activity in list)
        {
            Console.WriteLine(activity.GetSummary());
        } 

    }
}