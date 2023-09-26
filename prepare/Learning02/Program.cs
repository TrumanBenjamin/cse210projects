using System;

class Program
{
    static void Main(string[] args)
    {
        Job tbjob1 = new Job();
        tbjob1._tbjobTitle = "CEO";
        tbjob1._tbcompany = "Microsoft";
        tbjob1._tbstartYear = 2019;
        tbjob1._tbendYear = 2023;

        Job tbjob2 = new Job();
        tbjob2._tbjobTitle = "Janitor";
        tbjob2._tbcompany = "Apple";
        tbjob2._tbstartYear = 2015;
        tbjob2._tbendYear = 2018; 

        
        Resume myResume = new Resume();
        myResume._tbname = "Truman Benjamin";

        myResume._tbjobs.Add(tbjob1);
        myResume._tbjobs.Add(tbjob2);

        myResume.Display();
    }
   

}