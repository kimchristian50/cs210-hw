using System;
using System.Collections.Generic; // this is for lists

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    // constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // display the starting message
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(3);
    }

    // display the ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! ");
        ShowSpinner(4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
    }

    // pause while showing a spinner for a certain number of seconds
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int j = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[j];

            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            j++;

            if (j >= animationStrings.Count)
            {
                j = 0;
            }
        }
    }

    // pause while showing a countdown tinmer for a certain number of seconds
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // this backspaces so you can overwrite what you had
        }
    }

    public void ShowPeriodsCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("."); // this puts periods that increase
            Thread.Sleep(1000);
        }
    }
}