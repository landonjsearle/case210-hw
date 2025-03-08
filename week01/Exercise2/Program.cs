using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        String gradeString = Console.ReadLine();

        int grade = int.Parse(gradeString);

        String letterGrade;
       if (grade >= 90)
       {
            letterGrade = "A";
       }
       else if (grade >= 80)
       {
            letterGrade = "B";
       }
       else if (grade >= 70)
       {
            letterGrade = "C";
       }
       else if (grade >= 60)
       {
            letterGrade = "D";
       }
       else 
       {
            letterGrade = "F";
       }

       Console.WriteLine($"You got a {letterGrade}");

       if (grade >= 70)
       {
            Console.WriteLine("You did a great job!");
       }
       else
       {
            Console.WriteLine("Better luck next time.");
       }
    }
}