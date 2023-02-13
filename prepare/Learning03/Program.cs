using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Console.WriteLine(one.GetFractionInt());
        Fraction whole = new Fraction(6);
        Console.WriteLine(whole.GetWholeNumber());
        Fraction fraction = new Fraction(3, 4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}