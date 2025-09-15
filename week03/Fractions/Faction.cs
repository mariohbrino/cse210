using System;

class Fraction
{
    private int _top;
    private int _botton;

    public Fraction()
    {
        _top = 1;
        _botton = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _botton = 1;
    }

    public Fraction(int top, int botton)
    {
        _top = top;
        _botton = botton;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBotton()
    {
        return _botton;
    }

    public void SetBottom(int botton)
    {
        _botton = botton;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_botton}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_botton;
    }
}