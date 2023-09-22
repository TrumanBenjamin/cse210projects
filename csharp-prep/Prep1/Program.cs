using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string tbfirst = Console.ReadLine();

        Console.Write("What is your last name? ");
        string tblast = Console.ReadLine();

        Console.Write($"Your name is {tblast}, {tbfirst} {tblast}.");
    }
}