using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager= new GoalManager();
        goalManager.Start();

        Console.WriteLine("Thank you for useing the Goal manager!");
    }
}