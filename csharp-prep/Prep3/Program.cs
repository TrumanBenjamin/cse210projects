using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int tbmagicnumber = int.Parse(Console.ReadLine());

        int tbguess = 0;

        while (tbguess != tbmagicnumber)
        {
            Console.Write("What is your guess? ");
            tbguess = int.Parse(Console.ReadLine());

            if (tbguess > tbmagicnumber)
            {
            Console.WriteLine("That's not it. Try guessing lower! ");
            }
            else if (tbguess < tbmagicnumber)
            {
            Console.WriteLine("You guessed a little low. Try again! ");
            }
            else
            {
            Console.Write("You got it! ");
            }
        } 
        
    }
}