public class Rectangle : Shapes
{
    double _width;
    double _height;

    public Rectangle(double width, double height, String color) : base(color)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}