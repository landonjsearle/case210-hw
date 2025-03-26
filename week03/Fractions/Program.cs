using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.getFractionString());
        Console.WriteLine(f1.getFractionDecimal());
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.getFractionString());
        Console.WriteLine(f2.getFractionDecimal());
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.getFractionString());
        Console.WriteLine(f3.getFractionDecimal());

        f1.setNumerator(10);
        Console.WriteLine(f1.getNumerator());
        f2.setDenominator(10);
        Console.WriteLine(f2.getDenominator());

    }
}