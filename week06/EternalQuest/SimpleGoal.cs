using System;
using System.Collections.Concurrent;

public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete;

    // constructor

    // methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true; // placeholder
    }

    public override string GetStringRepresentation()
    {
        return "string";
    }
}