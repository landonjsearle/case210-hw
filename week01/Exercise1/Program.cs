using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, what is your first name?" );
        String firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        String lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}