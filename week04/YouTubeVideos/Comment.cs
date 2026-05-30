using System;

// track the name of the commentor and the text of the comment
// method to display the name+comment

public class Comment
{
    // attributes
    private string _name;
    private string _commentText;

    // constructors
    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    // methods
    public string GetDisplayText()
    {
        string text = $"{_name}: {_commentText}";
        return text;
    }
}