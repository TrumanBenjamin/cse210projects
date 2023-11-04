using System;
using System.Data;

class Reflection : Activity
{

    private string[] _prompts;
    private string[] _question;

    public Reflection(int duration, string spinner, string description, string response, string[] prompts, string[] question)
        : base(duration, spinner, description, response)
    {
        _prompts = prompts;
        _question = question;

    }

    public string getPrompt(int index)
    {
        return _prompts[index];
    }

    public void setPrompt(string prompt, int index)
    {
        _prompts[index] = prompt;

    }

    public string getQuestion(int index)
    {
        return _question[index];
    }

    public void setQuestion(string[] question)
    {
        _question = question;
    }

    
    public void startReflection()
    {
        Console.WriteLine("How long (in seconds) do you want to work on this activity?");
        
        int durationSeconds = int.Parse(Console.ReadLine);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationSeconds);

        while (DateTime.Now < endTime)
        {
            List<string> prompts = new List<string>{
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless." 
            };
            Random rand = new Random();

            int randomIndex = rand.Next(0, prompts.Count);
            string randomPrompt = prompts[randomIndex];
            Console.WriteLine(randomPrompt); 
            Thread.Sleep(5000);

            List<string> reflect = new List<string>{
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
            Random rand2 = new Random();

            int randIndex = rand.Next(0, reflect.Count);
            string randomReflect = reflect[randIndex];
            Console.WriteLine(randomReflect);

            List<string> animationStrings = new List<string>
            {
                "|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-", "\\"
            };

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
          
    }
}