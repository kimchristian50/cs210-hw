using System.Collections.Generic;
using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What challenged me most today?",
    "What am I most grateful for right now?",
    "How did I help or serve someone today?",
    "What small success did I have today?",
    "What lesson did today teach me?",
    "What made me smile or laugh today?",
    "What is something beautiful I noticed today?",
    "What might I want to remember about today a year from now?",
    "What was the most annoying or frustrating thing that happened today?",
    "What is one thing that made today different from yesterday?",
    "What is something I learned or understood better today?",
    "What is one thing I can do tomorrow to make it a better day?",
    "What gave me energy today, and what drained it?",
    "What prayer was answered today, even in a small way?",
    "What did I do today that aligned with the person I want to become?"
    };

    public string GetRandomPrompt()
    {
        // create a random object
        Random randomGenerator = new Random();
        // determine the range (0 to the count of the list)
        int index = randomGenerator.Next(0, _prompts.Count);
        // return the prompt at that index
        return _prompts[index];
    }
}

