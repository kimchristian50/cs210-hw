using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    // attributes
    private List<Goal> _goals;
    private int _score;

    // constructor
    public GoalManager()
    {
        // initialize the list
        _goals = new List<Goal>();

        // assign the score to start at 0
        _score = 0;
    }

    // methods
    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            int level = (_score / 100) + 1;

            Console.WriteLine();
            Console.WriteLine($"=====================================");
            Console.WriteLine($"  🏆 SCORE: {_score} | 👑 LEVEL: {level}");
            Console.WriteLine($"=====================================");

            Console.WriteLine("\n Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            if (choice == 1) // create new goal
            {
                CreateGoal();
            }

            else if (choice == 2) // list goals
            {
                ListGoalDetails();
            }

            else if (choice == 3) // save goals
            {
                SaveGoals();
            }

            else if (choice == 4) // load goals
            {
                LoadGoals();
            }

            else if (choice == 5) // record event
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        int level = (_score / 100) + 1;

        Console.WriteLine($"Your score is {_score}.");
        Console.WriteLine($"👑 CURRENT LEVEL: Level {level} 👑");
    }

    public void ListGoalNames()             // lists the names of each of the goals
    {

        int listNum = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{listNum}. {goal.ShortName}");
            ++listNum;
        }
    }

    public void ListGoalDetails()         // lists the details of each of the goals
    {
        int listNum = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{listNum}. {goal.GetDetailsString()}");
            ++listNum;
        }
    }

    public void CreateGoal()          // asks the user for information about a new goal, then creates the goal and adds it to the list
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        int goalType = int.Parse(Console.ReadLine());

        if (goalType == 1) // Simple goal
        {
            Console.WriteLine("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            string goalDesc = Console.ReadLine();
            Console.WriteLine("How many points should be associated with your goal?");
            int goalPoints = int.Parse(Console.ReadLine());

            SimpleGoal s1 = new SimpleGoal(goalName, goalDesc, goalPoints);

            _goals.Add(s1);

        }

        if (goalType == 2) // eternal goal
        {
            Console.WriteLine("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            string goalDesc = Console.ReadLine();
            Console.WriteLine("How many points should be associated with your goal?");
            int goalPoints = int.Parse(Console.ReadLine());

            EternalGoal e1 = new EternalGoal(goalName, goalDesc, goalPoints);

            _goals.Add(e1);
        }

        if (goalType == 3) // checklist goal
        {
            Console.WriteLine("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            string goalDesc = Console.ReadLine();
            Console.WriteLine("How many points should be associated with your goal?");
            int goalPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal c1 = new ChecklistGoal(goalName, goalDesc, goalPoints, goalTarget, goalBonus, 0);

            _goals.Add(c1);
        }
    }

    public void RecordEvent()           // asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal
    {
        //  checklist goals are updated to 1/3, 2/3, etc.
        ListGoalNames();
        Console.WriteLine();
        Console.WriteLine("Which goal did you accomplish? ");
        int selectedIndex = int.Parse(Console.ReadLine()) - 1;

        // pull that Goal object out of the list using the index
        Goal chosenGoal = _goals[selectedIndex];

        if (!chosenGoal.IsComplete())
        {
            // run the appropriate RecordEvent method to tell the goal to update its status
            chosenGoal.RecordEvent();

            // get the points from the goal using public method Points
            int pointsEarned = chosenGoal.Points;

            // add the points to the total score

            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("That goal has already been completed.");
        }
    }

    public void SaveGoals()         // saves the list of goals to a file
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()         // loads the list of goals from a file
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        Console.WriteLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        // take the score off the top line and save it to the class variable
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            // get the current line, skipping the first one because that's the score
            string line = lines[i];

            // break the line first by the : and then by ,
            string[] mainParts = line.Split(":");

            string goalType = mainParts[0];
            string remainingData = mainParts[1];

            if (goalType == "SimpleGoal")
            {
                string[] parts = remainingData.Split(",");

                string goalName = parts[0];
                string goalDesc = parts[1];
                string goalPoints = parts[2];
                string goalComplete = parts[3];

                int points = int.Parse(goalPoints);
                bool complete = bool.Parse(goalComplete);

                SimpleGoal s1 = new SimpleGoal(goalName, goalDesc, points);

                if (complete)
                {
                    s1.SetComplete(complete);
                }
                _goals.Add(s1);
            }

            if (goalType == "EternalGoal")
            {
                string[] parts = remainingData.Split(",");

                string goalName = parts[0];
                string goalDesc = parts[1];
                string goalPoints = parts[2];

                int points = int.Parse(goalPoints);

                EternalGoal e1 = new EternalGoal(goalName, goalDesc, points);

                _goals.Add(e1);
            }

            if (goalType == "ChecklistGoal")
            {
                string[] parts = remainingData.Split(",");

                string goalName = parts[0];
                string goalDesc = parts[1];
                string goalPoints = parts[2];
                string goalBonus = parts[3];
                string goalTarget = parts[4];
                string goalAmountCompleted = parts[5];

                int points = int.Parse(goalPoints);
                int bonus = int.Parse(goalBonus);
                int target = int.Parse(goalTarget);
                int amountCompleted = int.Parse(goalAmountCompleted);

                ChecklistGoal c1 = new ChecklistGoal(goalName, goalDesc, points, target, bonus, amountCompleted);

                _goals.Add(c1);
            }
        }
    }
}