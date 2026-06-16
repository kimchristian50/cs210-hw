using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        List<Activity> activities = new List<Activity>();

        RunningActivity r1 = new RunningActivity(DateTime.Today, 30, 2.5);
        activities.Add(r1);

        CyclingActivity c1 = new CyclingActivity(DateTime.Today, 55, 11.0);
        activities.Add(c1);

        SwimmingActivity s1 = new SwimmingActivity(DateTime.Today, 60, 25);
        activities.Add(s1);

        RunningActivity r2 = new RunningActivity(DateTime.Today, 69, 5);
        activities.Add(r2);

        CyclingActivity c2 = new CyclingActivity(DateTime.Today, 49, 9.5);
        activities.Add(c2);

        SwimmingActivity s2 = new SwimmingActivity(DateTime.Today, 35, 12);
        activities.Add(s2);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}