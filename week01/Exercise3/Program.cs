using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the Magic Number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);


        Boolean isCorrect = false;
        do
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higer");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("Correct"); 
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Invaild Response");
            }
        } while (isCorrect == false);
    }
}