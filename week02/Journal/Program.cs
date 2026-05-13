// I added a search function (5) that allows the user to search their journal entries for a searchTerm.

using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal theJournal = new Journal();

        while (choice != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");

            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            if (choice == 1)
            {
                // get the date for the journal entry
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // create an instance of the PromptGenerator class
                PromptGenerator myGenerator = new PromptGenerator();
                // activate the instance and save the result to the string randomPrompt
                string randomPrompt = myGenerator.GetRandomPrompt();
                // display randomPrompt
                Console.WriteLine($"{randomPrompt}");
                Console.Write("> ");

                // input will be saved as the entry - create an instance of the Entry class
                Entry anEntry = new Entry();
                anEntry._entryText = Console.ReadLine();
                anEntry._promptText = randomPrompt;
                anEntry._date = dateText;

                // send the completed entry to the journal
                theJournal.AddEntry(anEntry);
            }

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What is the file name? ");
                string myFile = Console.ReadLine();
                theJournal.LoadFromFile(myFile);
            }

            else if (choice == 4)
            {
                Console.Write("What is the file name? ");
                string myFile = Console.ReadLine();
                theJournal.SaveToFile(myFile);
            }

            else if (choice == 5)
            {
                Console.Write("What is the search term? ");
                string searchTerm = Console.ReadLine();
                theJournal.SearchEntries(searchTerm);
            }
        }



    }
}