using System;

class SimpleGoal : Goal
{

    private int _completionPoints;
    public SimpleGoal(string name, string description, int completionPoints) : base(name, description, "Simple")
    {
        _completionPoints = completionPoints;
    }

    public void goalCompleted() {
        setPoints(_completionPoints);
        setState(true);
    }
    public string GetName()
    {
        return getName();
    }

    public string GetDescription()
    {
        return GetDescription();
    }

    public string GetGoalType()
    {
        return getGoalType();
    }

}