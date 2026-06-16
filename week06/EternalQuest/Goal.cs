using System;

public abstract class Goal
{
    // attributes
    protected string _shortName;
    protected string _description;
    protected int _points;

    // constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // methods
    public abstract void RecordEvent();

    public abstract bool IsComplete();


    public virtual string GetDetailsString()

    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();
    // - provide all the details of a goal in a way that is easy to save to a file

    public virtual int Points
    {
        get { return _points; }
    }

    public string ShortName
    {
        get { return _shortName; }
    }
}