using System;

class Breathing : Activity{

    private string _prompt;

    public Breathing(int duration, string spinner, string description, string response, string prompt)
        : base(duration, spinner, description, response)
    {
        _prompt = prompt;
    }

    public string getPrompt()
    {
        return ""; // Change later to return prompt
    }

    public void breathe(int time)
    {
        // Start the breathing activity
    }
}