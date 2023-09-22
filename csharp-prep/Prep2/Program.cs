using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string tbanswer = Console.ReadLine();
        int tbpercentage = int.Parse(tbanswer);

        string tbletter = "";

        if (tbpercentage >= 90)
        {
            tbletter = "A";
        }
        else if (tbpercentage >= 80)
        {
            tbletter = "B";
        }
        else if (tbpercentage >= 70)
        {
            tbletter = "C";
        }
        else if (tbpercentage >= 60)
        {
            tbletter = "D";
        }
        else 
        {
            tbletter = "F";
        }
        Console.WriteLine($"Your grade is: {tbletter}. ");

        if (tbpercentage >= 70)
        {
            Console.Write("Congratulations! You passed! ");
        }
        else
        {
            Console.Write("Dang. That's a bummer. You didn't pass. Better luck next time! ");
        }
    }
}