using System;
using System.Collections.Generic; // this is for lists

// track the title, author, length of video (s), store a list of comments
// method to return the number of comments

public class Video
{
    // attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();    // creating a list of Comment objects

    // constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        // need to add comments to _comments
    }

    // methods

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public string GetDisplayText()
    {
        // set up the video information
        int countComments = CountComments();
        string videoInfo = $"'{_title}' - by {_author}, {_length} seconds long. There are {countComments} comments:\n";
        // loop through each Comment object inside the list container
        foreach (Comment currentCommentObject in _comments)
        {
            // call the Comment object's own GetDisplayText() method
            videoInfo += currentCommentObject.GetDisplayText() + "\n";
        }

        return videoInfo;
    }

    public int CountComments()
    {
        return _comments.Count;
    }
}