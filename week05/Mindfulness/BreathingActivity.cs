using System;

public class BreathingActivity : Activity
{
    // attributes

    // constructor
    public BreathingActivity()
      : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        // The base keyword handles setting the variables.
    }

    // method
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            Console.Write("\nNow breathe out... ");
            ShowCountdown(6);
        }
    }
}