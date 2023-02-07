using System;

class Fraction {

    private int _top;
    private int _bottom;

    public int GetFractionInt()
    {
        return 1;
    }
    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public int GetWholeNumber()
    {
        return _top;
    }
    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }
        public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }
}