using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        tbdisplaywelcomemessage(); 

        string tbusername = tbpromptusername();
        int tbusernumber = tbpromptusernumber();

        int tbsquarednumber = tbsquarenumber(tbusernumber);

        tbdisplayresult(tbusername, tbsquarednumber);
    
    }
    static void tbdisplaywelcomemessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }
    static string tbpromptusername()
    {
        Console.Write("Please enter your name: ");
        string tbname = Console.ReadLine();

        return tbname;
    }
    static int tbpromptusernumber()
    {
        Console.Write("Please enter your favorite number: ");
        int tbnumber = int.Parse(Console.ReadLine());

        return tbnumber;
    }
    static int tbsquarenumber(int tbnumber)
    {
        int tbsquare = tbnumber * tbnumber;
        
        return tbsquare;
    }
    static void tbdisplayresult(string tbname, int tbsquare)
    {
        Console.WriteLine($"{tbname}, the square of your number is {tbsquare}. ");  
    }

}