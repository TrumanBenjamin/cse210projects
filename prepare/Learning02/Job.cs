using System;

public class Job
{
    public string _tbjobTitle;
    public string _tbcompany;
    public int _tbstartYear;
    public int _tbendYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_tbjobTitle} ({_tbcompany}) {_tbstartYear}-{_tbendYear}");
    }


}