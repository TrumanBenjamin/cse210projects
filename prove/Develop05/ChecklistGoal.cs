using System;
using System.Reflection.Metadata;

class ChecklistGoal : Goal
{
    private int _target;
    private int _steps;
    private int _pointsPerStep;
    private int _pointsOnCompletion;


    public ChecklistGoal(string name, string description, int target, int pointsPerStep, int pointsOnCompletion) : base(name, description, "Checklist")
    {
        _target = target;
        _pointsPerStep = pointsPerStep;
        _pointsOnCompletion = pointsOnCompletion;
    }

    public void stepCompletion()
    {
        if (!getState())
        {
            if (_target != _steps)
            {
                _steps += 1;
            } else {
                setState(true);
            }
            setPoints(_steps * _pointsPerStep);
        }
    }

    public int calculatePoints()
    {
        if (_target == _steps || getState())
        {
            setPoints(_target * _pointsPerStep);
            setState(true);
            return getPoints();
        }
        else
        {
            setPoints(_steps * _pointsPerStep);
            return getPoints();
        }
    }
}