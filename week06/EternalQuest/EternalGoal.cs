using System;

public class EternalGoal : Goal
{
    // attributes

    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    // methods
    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress on your eternal goal!");
    }

    public override bool IsComplete()
    {
        return false; // eternal goals are never completed, they just add points when they are recorded
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

}