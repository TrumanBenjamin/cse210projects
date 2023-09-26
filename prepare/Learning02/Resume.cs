using System;

public class Resume
{

    public string _tbname;
    public List<Job> _tbjobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_tbname}");
        Console.WriteLine($"Jobs: {_tbjobs}");

        foreach (Job job in _tbjobs)
        {
            job.Display();
        }

    }
}