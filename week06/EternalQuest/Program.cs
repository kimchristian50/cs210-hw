using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            int points = 0;
            Console.WriteLine($"You have {points} points");

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

                    // then I will want to create a new goal using the name, desc, and points
                }

                if (goalType == 2) // eternal goal
                {

                }

                if (goalType == 3) // checklist goal
                {
                    // How many times does this goal need to be accomplished for a bonus?
                    // What is the bonus for accomplishing it that many times?
                }
            }

            if (choice == 2) // list goals
            {
                // will look like this: 1. [ ] Give a talk (Speak in Sacrament meeting when asked)
                // prob should have a GetDisplayText method in the class for this
                // the checklist goal looks like this: 3. [ ] Attend the temple (Attend and perform any ordinance) -- Currently completed: 0/3
            }

            if (choice == 3) // save goals
            {
                // What is the filename for the goal file? goals.txt
                // first line - # of points
                // second line - desc of goal 1
                // third line - desc of goal 2
                // 0
                // SimpleGoal:Give a talk, Speak in Sacrament meeting when asked,100,False
                // EternalGoal:Study the scriptures,Study for at least 10 minutes, 50
                // Checklistgoal:Attend the temple,Attend and perform any ordinance,50,500,3,0
                // type of goal:goal description,points
            }
            if (choice == 4) // load goals
            {
                // what is the filename for the goals file?
            }
            if (choice == 5) // record event
            {
                // lists the gaols
                // Which goal did you accomplish? 2
                // Congratulations! You have earned 50 points!
                // You now have 50 points.
                // eternal goals don't get a checkmark, but simple goals can be checked off [X]
                // checklist goals are updated to 1/3, 2/3, etc.
            }
        }
    }
}
