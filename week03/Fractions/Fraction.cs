using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNubmer)
    {
        _top = wholeNubmer;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int getNumerator()
    {
        return _top;
    }

    public void setNumerator(int numerator)
    {
        _top = numerator;
    }


    public int getDenominator()
    {
        return _bottom;
    }

    public void setDenominator(int denominator)
    {
        _bottom = denominator;
    }

    public String getFractionString()
    {
        return $"{_top} / {_bottom}";
    }

    public double getFractionDecimal()
    {
        return (double)_top / (double)_bottom;
    }
}