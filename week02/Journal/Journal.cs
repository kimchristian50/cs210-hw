using System.IO;
using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine($"Saving to file {filename}");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // add text to the file with the WriteLine method
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Loading file...");

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Console.WriteLine(line); // line looks like this: 5/13/2026|What might I want to remember about today a year from now?|testing1
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            AddEntry(newEntry);

        }
    }
    public void SearchEntries(string searchTerm)
    {
        Console.WriteLine($"\n--- Searching for: '{searchTerm}' ---");
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry._entryText.ToLower().Contains(searchTerm.ToLower()) || entry._promptText.ToLower().Contains(searchTerm.ToLower()))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching entries found.");
        }

    }


}