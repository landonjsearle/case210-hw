using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Pleae enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
            numbers.Add(number);
            }
        } while (number != 0);


        int sum = 0;
        int max = -1;
        int min = numbers[0];
        foreach (int iNumber in numbers)
        {
            sum = sum + iNumber;

            if (iNumber < min)
            {
                min = iNumber;
            }

            if (iNumber > max)
            {
                max = iNumber;
            }
        }

        double average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum of the numbers is {sum}");
        Console.WriteLine($"The Mean of the number is {average}");
        Console.WriteLine($"The Largest number in the list is {max}");
        Console.WriteLine($"The Smallest number in the list is {min}");
    }
}