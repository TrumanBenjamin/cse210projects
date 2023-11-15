using System;

class Goal
{

    private string _name;
    private int _points;
    private string _description;
    private bool _completed;

    // For Goal Type:
    // int 0 = Simple
    // int 1 = Checklist
    // int 2 = Eternal
    private int _goalType;

    public Goal(string name, string description, string goalType="Simple")
    {
        _name = name;
        _description = description;
        _points = 0;
        _completed = false;
        if (goalType == "Simple") {
            _goalType = 0;
        } else if (goalType == "Checklist") {
            _goalType = 1;
        } else if (goalType == "Eternal") {
            _goalType = 2;
        }
    }

    public int getPoints()
    {
        return _points;
    }

    protected void setPoints(int points)
    {
        _points = points;
    }

    public string getName()
    {
        return _name;
    }

    public string getDescription()
    {
        return _description;
    }

    public string getGoalType()
    {
        if (_goalType == 0) {
            return "Simple";
        } else if (_goalType == 1) {
            return "Checklist";
        } else if (_goalType == 2) {
            return "Eternal";
        } else {
            return null;
        }
    }

    protected bool getState()
    {
        return _completed;
    }

    protected void setState(bool state) {
        _completed = state;
    }
}