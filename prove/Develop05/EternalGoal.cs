using System;

class EternalGoal : Goal
{

    private int _steps;
    private int _pointsPerStep;

    public EternalGoal(string name, string description, int pointsPerStep) : base(name, description, "Eternal") 
    {
        _pointsPerStep = pointsPerStep;
    }

    public int calculatePoints()
    {
        setPoints(_steps * _pointsPerStep);
        return getPoints();
    }

    public void stepsCompleted(int x)
    {
        setPoints(getPoints() + (_pointsPerStep * x));
    }
}