// To exceed the basic requirements, I separated the punctuation from the word in Word so that the punctuation remains when the word is hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        // create the reference label
        Reference scriptureReference = new Reference("Micah", 7, 8);

        // write out the actual raw text string
        string rawText = "Rejoice not against me, O mine enemy: when I fall, I shall arise; when I sit in darkness, the Lord shall be a light unto me.";
        // clear the console
        Console.Clear();
        // create the Scripture object, passing the reference label and the text string inside
        Scripture newScripture = new Scripture(scriptureReference, rawText);
        Console.WriteLine(newScripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "quit" && !newScripture.IsCompletelyHidden())
        {
            Console.Clear();
            newScripture.HideRandomWords(3);
            Console.WriteLine(newScripture.GetDisplayText());                       // display the new text

            if (newScripture.IsCompletelyHidden())
            {
                break;                                                              // if it's completely hidden, exit the program then
            }
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();                                          // find out if the user wants to keep going                        
        }
    }
}