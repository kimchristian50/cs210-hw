using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumberString = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberString);

        string replay = "y";

        while (replay != "n")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);

            int numberGuesses = 1;

            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guessString = Console.ReadLine();
                    guess = int.Parse(guessString);
                    numberGuesses++;
                }
                else
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guessString = Console.ReadLine();
                    guess = int.Parse(guessString);
                    numberGuesses++;
                }
            }
            Console.WriteLine($"You guessed it! It took you {numberGuesses} tries.");
            Console.Write("Do you want to play again? (y/n) ");
            replay = Console.ReadLine();
        }
    }
}