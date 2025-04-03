using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment= new Assignment("Landon", "Math");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment= new MathAssignment("Landon", "Math", "Equateral Triangles 7.9", "15-26");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WrittingAssignment writtingAssignment= new WrittingAssignment("Landon", "Ancient History", "Mummies and Sand");
        Console.WriteLine(writtingAssignment.GetSummary());
        Console.WriteLine(writtingAssignment.GetWrittingInfo());
    }
}