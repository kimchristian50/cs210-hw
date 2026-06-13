using System;
using System.Collections.Generic; // this is for lists

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _unusedQuestions;

    // constructor
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // initialize the lists
        _prompts = new List<string>();
        _questions = new List<string>();

        // Populate the prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a recent accomplishment, no matter how big or small.");
        _prompts.Add("Think of a time when you recently eased someone's burden in some small way.");
        _prompts.Add("Think of a time when you truly listened to someone without planning your response.");
        _prompts.Add("Think of a time when a simple smile, wave, or kind word to a stranger brightened your day or theirs.");
        _prompts.Add("Think of a time when you were kind, even though it might not have been easy.");

        // Populate the reflecting questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when the experience was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("Is there someone that you could share this experience with?");

        // Initialize the tracking list with a fresh copy of everything in the master list
        _unusedQuestions = new List<string>(_questions);
    }

    // methods
    public void Run()
    {
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(3);
        // backspace 18 times to completely erase the phrase "You may begin in: "
        Console.Write(new string('\b', 18));
        // overwrite the blank space with new message
        Console.WriteLine("You may begin now! ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Loop continuously until the user's allocated time runs out
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }
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

    public string GetRandomQuestion()
    {
        // create a random object
        Random randomGenerator = new Random();

        // if we have used all available questions, refill the list from the master list
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        // determine the range (0 to the count of the list of unused questions)
        int index = randomGenerator.Next(0, _unusedQuestions.Count);
        // choose a question from the unused list
        string chosenQuestion = _unusedQuestions[index];
        // remove that question from the unused list so it can't be repeated in the same session
        _unusedQuestions.RemoveAt(index);

        // return the prompt at that index
        return chosenQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        // this pauses the program until they press enter
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();
    }

    public void DisplayQuestion()
    {
        Console.Write($"\n> {GetRandomQuestion()} ");
        ShowSpinner(10);
    }
}