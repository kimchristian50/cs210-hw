using System;
using System.Reflection;

public class GoalManager
{
    // attributes
    private List<Goal> _goals;
    private int _score;

    // constructor
    // methods
    public void Start()
    {
        // main function of the class, it's called by Program.cs and then runs the menu loop (which I have there at the moment)
    }

    public void DisplayPlayerInfo()
    {
        // displays the player's current score
    }

    public void ListGoalNames()
    {
        // lists the names of each of the goals
    }

    public void ListGoalDetails()
    {
        // lists the details of each of the goals
    }

    public void CreateGoal()
    {
        // asks the user for information about a new goal, then creates the goal and adds it to the list
    }

    public void RecordEvent()
    {
        // asks the user which goal they have done and then records teh event by calling the RecordEvent method on that goal
    }

    public void SaveGoals()
    {
        // saves the list of goals to a file
    }

    public void LoadGoals()
    {
        // loads the list of goals from a file
    }
}