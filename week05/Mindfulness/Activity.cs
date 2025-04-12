using System;
using System.Diagnostics.Metrics;

public class Activity
{
    private String _activityName;
    private int _duration;
    private String _description;

    public Activity()
    {

    }

    public Activity(String name, String description, int duration)
    {
        _activityName = name;
        _duration = duration;
        _description = description;
    }

    public void ShowSpinner(int seconds)
    {

        // Console.WriteLine("Working...");
        List<String> spinChar = new List<string>();
        spinChar.Add("|");
        spinChar.Add("/");
        spinChar.Add("-");
        spinChar.Add("\\");
        int countDown = 0;  
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);


        while (DateTime.Now <  end)
    {
            Console.Write(spinChar[countDown % spinChar.Count()]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            countDown++;
        }

    }

    public void ShowCountdown(int seconds)
    {
        if (seconds > 9)
        {
            seconds = 9;
        }
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public String GetStartMessage()
    {
        String display = $"Activity: {_activityName} \nDescrtiption: {_description}";
        return display;
    }
    
    public String GetEndMessage()
    {
        return "Thank you for using this activity!";
    }

    public String GetActivityName()
    {
        return _activityName;
    }
    public String GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void SetActivtyName(string name)
    {
        _activityName = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}
