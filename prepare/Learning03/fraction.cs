using System;
using System.Diagnostics;

public class Fraction
{
    private int _tbtop;
    private int _tbbottom;

    public Fraction()
    {
        _tbtop = 1;
        _tbbottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _tbtop = wholeNumber;
        _tbbottom = 1;
    }
    public Fraction(int top, int bottom) 
    {
        _tbtop = top;
        _tbbottom = bottom;
    }
    public string tbGetFractionString()
    {
        string text = $"{_tbtop}/{_tbbottom}";
        return text;
    }
    public double tbGetDecimalValue()
    {
        return (double)_tbtop / (double)_tbbottom;
    }



}