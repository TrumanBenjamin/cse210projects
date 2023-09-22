using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> tbnumbers = new List<int>();

        int tbinput = -1;
        while (tbinput != 0)
        {
            Console.Write("Enter a list of numbers, type 0 to quit. ");
            string tbresponse = Console.ReadLine();
            tbinput = int.Parse(tbresponse);
            if (tbinput !=0)
            {
                tbnumbers.Add(tbinput);
            }
        }

        int tbsum = 0;
        foreach (int tbnumber in tbnumbers)
        {
            tbsum += tbnumber;
        }
        Console.WriteLine($"The sum is {tbsum} ");

        float tbaverage = ((float)tbsum) / tbnumbers.Count;
        Console.WriteLine($"The average is: {tbaverage}. ");

        int tbmax = tbnumbers[0];

        foreach (int tbnumber in tbnumbers)
        {
            if (tbnumber > tbmax)
            {
                tbmax = tbnumber;
            }
        }
        Console.WriteLine($"The max is: {tbmax}. ");
    }
}