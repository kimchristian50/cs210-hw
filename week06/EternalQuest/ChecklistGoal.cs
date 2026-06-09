using System;

public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // constructor

    // methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true; // placeholder
    }

    public override string GetDetailsString()
    {
        return "string";
    }

    public override string GetStringRepresentation()
    {
        return "string";
    }
}