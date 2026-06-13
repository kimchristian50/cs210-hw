using System;

public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    // methods
    public override void RecordEvent()
    {
        // increment the amount completed
        _amountCompleted++;

    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string statusCheckbox = "[ ]";
        if (IsComplete())
        {
            statusCheckbox = "[X]";
        }
        return $"{statusCheckbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        // Checklistgoal:Attend the temple,Attend and perform any ordinance,50,500,3,0
    }

    public override int Points
    {
        get
        {
            // If we just hit the target, return regular points + bonus!
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }

            // Otherwise, just return the standard points
            return _points;
        }
    }
}