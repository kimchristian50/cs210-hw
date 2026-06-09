using System;

public abstract class Goal
{
    // attributes
    private string _shortName;
    private string _description:
    private int _points;

    // constructor

    // methods
    public abstract void RecordEvent()
    //- whatever is necessary for each specific kind of goal, returns the point value associated with recording the event
    // including a bonus if applicable 
    // should be overwritten by the derived classes (so it is abstract)
    {

    }


    public abstract bool IsComplete()
    // - return true if the goal is complete, the way you do this is different for each goal
    // should be overwritten by the derived classes
    {

    }

    public virtual string GetDetailsString()
    // - return the details of a goal that could be shown in a list
    // should include the checkbox, the short name, the description, and for a ChecklistGoal it should be overridden to show the number of
    // times it's been accomplished already (so it has to be virtual)
    {

    }

    public abstract string GetStringRepresentation()
    // - provide all the details of a goal in a way that is easy to save to a file
    {
        
    }
}