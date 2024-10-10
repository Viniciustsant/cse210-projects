using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction ();
        //Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()}");
        Console.WriteLine(fraction1.GetFractionalString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction (5);
        Console.WriteLine(fraction2.GetFractionalString());
        Console.WriteLine(fraction2.GetDecimalValue());
        //fraction2.SetTop(5);
        //Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");

        Fraction fraction3 = new Fraction (3,4);
        Console.WriteLine(fraction3.GetFractionalString());
        Console.WriteLine(fraction3.GetDecimalValue());
        //fraction3.SetTop(2);
        //fraction3.SetBottom(9);
        //Console.WriteLine($"{fraction3.GetTop()}/{fraction3.GetBottom()}");

        Fraction fraction4 = new Fraction (1,3);
        Console.WriteLine(fraction4.GetFractionalString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}