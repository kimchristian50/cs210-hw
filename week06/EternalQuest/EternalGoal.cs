using System;

public class EternalGoal : Goal
{
    // attributes

    // constructor

    // methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false; // eternal goals are never completed, they just add points when they are recorded
    }

    public override string GetStringRepresentation()
    {
        return "string";
    }

}