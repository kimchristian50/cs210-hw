using System;

public class Entry
{
    public string _date;
    public string _entryText;
    public string _promptText;


    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}