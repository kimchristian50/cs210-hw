using System;

// Keeps track of a single word and whether it is shown or hidden

public class Word
{
    // Attributes:
    private string _text;
    private string _punctuation;
    private bool _isHidden;

    // Constructor:
    public Word(string rawText)
    {
        _isHidden = false;
        _punctuation = "";  //start empty by default

        // make sure the string isn't empty
        if (rawText.Length > 0)
        {
            // get the last character in the string
            char lastChar = rawText[rawText.Length - 1];

            // is it a punctuation mark?
            if (char.IsPunctuation(lastChar))
            {
                // save the punctuation mark by itself
                _punctuation = lastChar.ToString(); // turn it into a string and save it as _punctuation

                // save the rest of the text without that last character
                _text = rawText.Substring(0, rawText.Length - 1);
            }
            else        // if there is no punctuation, just save the whole thing to _text
            {
                _text = rawText;
            }
        }
    }

    // Methods:
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // turn only the actual letters into underscores
            int lettersLength = _text.Length;
            string underscores = new string('_', lettersLength);

            // add the punctuation back onto the end
            return underscores + _punctuation;
        }
        else
        {
            // if it isn't hidden, return the letters plus the punctuation
            return _text + _punctuation;
        }
    }
}