using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square squ= new Square(3, "Red");
        // Console.WriteLine($"{squ.GetColor()} {squ.GetArea()}");

        Rectangle rectangle= new Rectangle(3, 5, "blue");
        // Console.WriteLine($"{rectangle.GetColor()} {rectangle.GetArea()}");

        Circle circle= new Circle(6, "Purple");
        // Console.WriteLine($"{circle.GetColor()} {circle.GetArea()}");

        List<Shapes> shapes= new List<Shapes>();
        shapes.Add(squ);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shapes shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} ");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}