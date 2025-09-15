using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString() + " => " + fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2.GetFractionString() + " => " + fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3.GetFractionString() + " => " + fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(5);
        Console.WriteLine(fraction4.GetFractionString() + " => " + fraction4.GetDecimalValue());

        Fraction fraction5 = new Fraction(3, 4);
        Console.WriteLine(fraction5.GetFractionString() + " => " + fraction5.GetDecimalValue());

        Fraction fraction6 = new Fraction();
        fraction6.SetTop(6);
        fraction6.SetBottom(12);

        Console.WriteLine(fraction6.GetFractionString());
        Console.WriteLine(fraction6.GetDecimalValue());
        Console.WriteLine($"Fraction top: {fraction6.GetTop()}");
        Console.WriteLine($"Fraction botton: {fraction6.GetBotton()}");
    }
}