using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int numberSq = SquareNumber(number);

        DisplayResult(name, numberSq);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numInput = Console.ReadLine();
            int number = int.Parse(numInput);
            return number;
        }

        static int SquareNumber(int number)
        {
            int numberSq = number * number;
            return numberSq;
        }

        static void DisplayResult(string name, int numberSq)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSq}");
        }



    }
}