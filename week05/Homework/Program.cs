using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Thomas Jefferson", "Physics");

        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("John Adams", "geometry", "3.3", "1-99");
        Console.WriteLine(assign2.GetMathSummary());

        WritingAssignment assign3 = new WritingAssignment("Benjamin Franklin", "Writing 101", "Autobiography");
        Console.WriteLine(assign3.GetWritingSummary());
    }
}