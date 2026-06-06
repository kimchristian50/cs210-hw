using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu Options:
        // 1. Start breathing activity
        // 2. Start reflecting activity
        // 3. Start listing activity
        // 4. Quit
        // Select a choice from the menu:
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            if (choice == 1)
            {
                BreathingActivity breathingApp = new BreathingActivity();
                breathingApp.DisplayStartingMessage();
                breathingApp.Run();
                breathingApp.DisplayEndingMessage();
            }

            if (choice == 2)
            {
                ReflectingActivity reflectingApp = new ReflectingActivity();
                reflectingApp.DisplayStartingMessage();
                reflectingApp.Run();
                reflectingApp.DisplayEndingMessage();
            }

            if (choice == 3)
            {
                ListingActivity listingApp = new ListingActivity();
                listingApp.DisplayStartingMessage();
                listingApp.Run();
                listingApp.DisplayEndingMessage();
            }
        }
    }
}