public abstract class Shapes
{
    String _color;



    public Shapes(String color)
    {
        _color = color;
    }

    public String GetColor()
    {   
        return _color;
    }
    public void SetColor(String color)
    {
        _color = color;
    }


    public virtual double GetArea()
    {
        return -0.1;
    }
}