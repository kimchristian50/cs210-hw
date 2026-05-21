using System;

// Keeps track of the book, chapter, and verse information
// get the display text of the reference - a string combining the book, chapter, and verse

public class Reference
{
    // attributes:
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // constructors:
    // constructor 1 - for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    // constructor 2 - for multiple verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // methods:
    // This method is useful so the Scripture clss doesn't need to format how the reference is displayed
    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    } 
}