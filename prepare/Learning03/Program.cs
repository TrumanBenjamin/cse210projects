using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fraction tbf1 = new Fraction();
        Console.WriteLine(tbf1.tbGetFractionString());
        Console.WriteLine(tbf1.tbGetDecimalValue());

        Fraction tbf2 = new Fraction(5);
        Console.WriteLine(tbf2.tbGetFractionString());
        Console.WriteLine(tbf2.tbGetDecimalValue());

        Fraction tbf3 = new Fraction(3,4);
        Console.WriteLine(tbf3.tbGetFractionString());
        Console.WriteLine(tbf3.tbGetDecimalValue());

        Fraction tbf4 = new Fraction(1,3);
        Console.WriteLine(tbf4.tbGetFractionString());
        Console.WriteLine(tbf4.tbGetDecimalValue());
    }
}