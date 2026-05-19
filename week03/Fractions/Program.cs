using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(1, 2);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.Write("What is the numerator? ");
        int top = int.Parse(Console.ReadLine());
        Console.Write("What is the denominator? ");
        int bottom = int.Parse(Console.ReadLine());

        Fraction f4 = new Fraction(top, bottom);
        f4.SetTop(top);
        f4.SetBottom(bottom);
        Console.WriteLine($"top is {f4.GetTop()}");
        Console.WriteLine($"bottom is {f4.GetBottom()}");
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}