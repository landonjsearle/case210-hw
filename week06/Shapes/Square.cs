using System.Reflection.Metadata.Ecma335;

public class Square : Shapes
{
    double _side;

    public Square(double side, String color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}