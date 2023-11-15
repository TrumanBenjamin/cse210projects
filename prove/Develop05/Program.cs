using System;
using System.Dynamic;
using System.Collections.Generic;
using System.IO;

class Program
{

    static int totalPoints = 0;
    static List<Goal> goals = new List<Goal>();
    static void Main(string[] args)
    {
        int choice = 0;
        // insert Load Function Here

        while (choice != 6)
        {
            displayWelcomeMessage();
            try
            {
                choice = int.Parse(getUserInput("Select a choice from the menu: "));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (choice == 1)
            {
                // Create a goal
                createGoal();
            }
            else if (choice == 2)
            {
                // List all goals
                Console.Clear();
                int index = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(index + ". " + goal.getGoalType() + ": " + goal.getName() + ", " + goal.getDescription());
                    index++;
                }
                getUserInput("Press enter to return to menu.");
            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {

            }
            else if (choice == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid menu choice.");
            }
        }
        Console.WriteLine("Thanks for using the Goal tracker!");
    }


    static void displayWelcomeMessage()
    {
        Console.Write("Test");
        Console.Clear();
        Console.WriteLine("You currently have " + totalPoints + " points.\n");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
    }

    static void createGoal()
    {
        Console.Clear();
        Console.WriteLine("\t1. Eternal Goal");
        Console.WriteLine("\t2. Simple Goal");
        Console.WriteLine("\t3. Checklist Goal");
        int choice1 = int.Parse(getUserInput("Please select a Goal: "));
        string goalName = getUserInput("Goal Name: ");
        string goalDescription = getUserInput("Write a short description of it: ");
        if (choice1 == 1)
        {
            int pointsPerStep = int.Parse(getUserInput("Points per completion: "));
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, pointsPerStep);
            goals.Add(eternalGoal);
        }
        else if (choice1 == 2)
        {
            int completionPoints = int.Parse(getUserInput("Points upon completion: "));
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, completionPoints);
            goals.Add(simpleGoal);
        }
        else if (choice1 == 3)
        {
            int target = int.Parse(getUserInput("Time to completion: "));
            int pointsPerStep = int.Parse(getUserInput("Points per step: "));
            int pointsOnCompletion = int.Parse(getUserInput("Points once goal is reached: "));
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, target, pointsPerStep, pointsOnCompletion);
            goals.Add(checklistGoal);
        }
        Console.WriteLine("\n\tGoal created!");
    }

    static string getUserInput(string text)
    {
        Console.Write(text);
        string input = Console.ReadLine();
        return input;
    }

}