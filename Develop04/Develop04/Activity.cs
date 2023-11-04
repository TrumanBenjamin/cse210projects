using System;
using System.ComponentModel;

class Activity
{
    private int _duration;
    private string _spinner;
    private string _description;
    private string _response;

    public Activity(int duration, string spinner, string description, string response)
    {
        _duration = duration;
        _spinner = spinner;
        _description = description;
        _response = response;
    }

    public int getDuration()
    {
        return _duration;
    }

    public void setDuration(int duration)
    {  
        _duration = duration;
    }

    public int getDurationMinutes()
    {
        return _duration / 60;
    }

    public string getSpinner()
    {
        return _spinner;
    }

    public string getDescription() 
    {
        return _description;
    }

    public void setDescription(string description)
    {
        _description = description;
    }

    public string getResponse()
    {
        return _response;
    }

    public void setResponse(string response)
    {
        _response = response;
    }
    public void displayMenu()
    {
        
    }
    public void displayStartMessage()
    {
        Console.WriteLine("Welcome to the ... activity");
    }
}
