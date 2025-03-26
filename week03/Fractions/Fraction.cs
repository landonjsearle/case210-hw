using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    Fraction(int wholeNubmer)
    {
        _top = wholeNubmer;
        _bottom = 1;
    }
    Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
}