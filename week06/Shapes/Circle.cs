public class Circle : Shapes
{
    double _radius;

    public Circle(double radius, String color) : base( color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}