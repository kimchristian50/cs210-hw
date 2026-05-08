using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string grade = Console.ReadLine();
        float gradePercent = float.Parse(grade);

        string letterGrade = "";
        string gradeSign = "";

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        float remainder = gradePercent % 10;
        if (remainder >= 7)
        {
            gradeSign = "+";
            if (gradePercent > 90 || gradePercent < 60)
            {
                gradeSign = "";
            }
        }
        else if (remainder <= 3)
        {
            gradeSign = "-";
            if (gradePercent < 60)
            {
                gradeSign = "";
            }
        }

        Console.WriteLine($"Your grade is {letterGrade}{gradeSign}.");

        if (gradePercent < 70)
        {
            Console.WriteLine("You need a 70% or higher to pass. You'll get it next time!");
        }
        else
        {
            Console.WriteLine("Congratulations, you passed!");
        }
    }
}