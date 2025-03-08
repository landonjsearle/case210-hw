using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int favNumber = PromptUserNumber();
        int favNumberSquared = SquareNumber(favNumber);
        DisplayResults(favNumberSquared, name);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello, Welcome to your program");
    }

    static String PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResults(int squaredNumber, String username)
    {
        Console.WriteLine($"{username}, the square of your favorite nummber is {squaredNumber}");
    }
}