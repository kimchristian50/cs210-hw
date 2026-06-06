using System;
using System.Collections.Generic; // this is for lists
using System.IO;

public class ListingActivity : Activity
{
    // Welcome to the Listing Activity.
    // This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.
    // How long, in seconds, would you like for your session?
    // Get ready... (spinner)
    // List as many respones as you can to the following prompt:
    // --- When have you felt the Holy Ghost this month? ---
    // You may begin in: (countdown)
    // You listed 4 items!
    // Well done!
    // You have completed another 20 seconds of the Listing activity.

    // get a ramdom prompt
    // get a list of responses from the user

    private int _count;
    private List<string> _prompts;

    public ListingActivity()
  : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // initialize the list
        _prompts = new List<string>();

        // Populate the prompts
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What aspects of nature have been beautiful this week?");
        _prompts.Add("What are some small comforts that make your daily life better?");
        _prompts.Add("What are places where you feel peaceful or safe?");
        _prompts.Add("What skills or abilities are you grateful to have developed?");
        _prompts.Add("What are some happy memories that still make you smile?");
        _prompts.Add("What foods, smells, or sounds bring you comfort or joy?");
        _prompts.Add("What challenges have helped you grow into a stronger person?");
        _prompts.Add("What routines or habits help your life feel stable and healthy?");
        _prompts.Add("What are some acts of kindness you have received from other people?");
        _prompts.Add("What are things in modern life that make your life easier or more enjoyable?");
        _prompts.Add("What goals or future experiences are you excited about?");
        _prompts.Add("What are some books, movies, songs, or artworks that have influenced you positively?");
        _prompts.Add("What are some qualities about yourself that you appreciate?");
        _prompts.Add("What are things your family or friends have taught you that you value?");
        _prompts.Add("What moments recently made you laugh?");
        _prompts.Add("What are some beautiful details you noticed today that you might normally overlook?");
        _prompts.Add("What opportunities have opened doors in your life?");
        _prompts.Add("What traditions or rituals give your life meaning?");
        _prompts.Add("What are some ways your body helps you experience the world?");
        _prompts.Add("What are things you used to take for granted but appreciate more now?");
    }

    public void Run()
    {
        Console.Clear();

        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        // backspace 18 times to completely erase the phrase "You may begin in: "
        Console.Write(new string('\b', 18));
        // overwrite the blank space with new message
        Console.WriteLine("You may begin now! ");
        Console.WriteLine();

        // initialize a clean local list to collect items
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Loop continuously until the user's allocated time runs out
        while (DateTime.Now < endTime)
        {
            string input = GetListFromUser();

            // check to ensure the user entered something
            if (!string.IsNullOrEmpty(input))
            {
                responses.Add(input);
            }
        }
        _count = responses.Count;
        Console.WriteLine($"\nYou listed {_count} items!");
        // DisplayList(responses);
    }

    public string GetRandomPrompt()
    {
        // create a random object
        Random randomGenerator = new Random();
        // determine the range (0 to the count of the list)
        int index = randomGenerator.Next(0, _prompts.Count);
        // return the prompt at that index
        return _prompts[index];
    }

    public string GetListFromUser()
    {
        Console.Write("> ");
        return Console.ReadLine();
    }

    public void DisplayList(List<string> responses)
    {
        foreach (string i in responses)
        {
            Console.WriteLine(i);
        }
    }
}