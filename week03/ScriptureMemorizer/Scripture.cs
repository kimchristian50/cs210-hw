using System;
using System.Collections.Generic; // this is for lists

// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
// hide random words
// get the display text as a string

public class Scripture
{
    // attributes:
    private Reference _reference;
    // private = locked inside this class
    // List<Word> = a dynamic array container that is strictly forbidden from holding anything except Word objects
    // = new List<Word>() = actually builds the empty container in memory
    private List<Word> _words = new List<Word>(); // creating a list of word objects

    // constructors:
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // chop the text into an array of separate strings whereever there's a space
        string[] splitWords = text.Split(' ');
        // loop through each string word, turn it into a Word object, and add it to the Word list
        foreach (string singleWordText in splitWords)
        {
            // Create a new instance of the Word class for this specific word   
            Word newWordObject = new Word(singleWordText);
            // Add it to our master list
            _words.Add(newWordObject);
        }
    }

    // methods:

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        int wordsHiddenThisTurn = 0;

        // count how many words in _words are not hidden
        int visibleCount = _words.Count(word => !word.IsHidden());
        // if there are fewer than 3 left, change numberToHide to however many there are
        if (visibleCount < numberToHide)
        {
            numberToHide = visibleCount;
        }

        while (wordsHiddenThisTurn < numberToHide)
        {
            // make rNumber a random number between 0 and _words.Count - 1 (which is what the .Next method does)
            int rNumber = randomGenerator.Next(0, _words.Count);

            // find the Word associated with that random number
            Word selectedWord = _words[rNumber];

            // check to see if it's hidden already
            if (!selectedWord.IsHidden())
            {
                selectedWord.Hide();
                wordsHiddenThisTurn++; // increment the counter because a word was successfully hidden
            }
        }
    }

    public string GetDisplayText()
    {
        // start with the Reference text at the front
        string fullScriptureText = $"{_reference.GetDisplayText()} ";
        // loop through every Word object inside the list container
        foreach (Word currentWordObject in _words)
        {
            // call the Word object's own GetDisplayText() method, this makes sure it returns the spelling or the spaces if hidden
            fullScriptureText += currentWordObject.GetDisplayText() + " ";
        }
        return fullScriptureText;
    }

    public bool IsCompletelyHidden()
    {
        int visibleCount = _words.Count(word => !word.IsHidden());
        if (visibleCount == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}