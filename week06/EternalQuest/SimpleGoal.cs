using System;

public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete;

    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // methods
    public override void RecordEvent()
    {
            SetComplete(true);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        // SimpleGoal:Give a talk,Speak in Sacrament meeting when asked,100,False
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
}