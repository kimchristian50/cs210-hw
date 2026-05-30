using System;
using System.Collections.Generic; // this is for lists

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // create the Video objectsd, passing the title, author, and length string to Video
        Video newVideo = new Video("Photoshop Secrets", "Gryffin King", 1485);

        // create a comment object and send it to the video's method for each comment
        Comment newComment = new Comment("Ruby", "This video blew my mind, it's going to change how I edit photos forever!");
        newVideo.AddComment(newComment);
        newComment = new Comment("Alice", "Thanks for the great tips!");
        newVideo.AddComment(newComment);
        newComment = new Comment("Betsey", "this is fire");
        newVideo.AddComment(newComment);
        newComment = new Comment("Leo", "Does this work for video as well or just for photos?");
        newVideo.AddComment(newComment);
        videosList.Add(newVideo); // add this video object to the List videosList


        // create video2 object
        newVideo = new Video("Pest Control will make you MONEY", "Joseph Anderson", 550);
        newComment = new Comment("Porter", "It sounds like it's worth a try, thanks bruv");
        newVideo.AddComment(newComment);
        newComment = new Comment("Beckett", "No way");
        newVideo.AddComment(newComment);
        newComment = new Comment("Mia", "I think it might be more complicated than this.");
        newVideo.AddComment(newComment);
        videosList.Add(newVideo);


        // create video3 object
        newVideo = new Video("Bears in the mountains near Colorado Springs", "Perry Pierce", 125);
        newComment = new Comment("Pam", "These bears are amazing! Why do I never see bears like this?");
        newVideo.AddComment(newComment);
        newComment = new Comment("Mattie", "I think I saw the first bear too!");
        newVideo.AddComment(newComment);
        newComment = new Comment("Mike", "I've learned to put my cooler in the truck at night, even if it's empty.");
        newVideo.AddComment(newComment);
        newComment = new Comment("Dockson", "I sure hope I see a bear when I'm in the mountains next time, thanks for the great video!");
        newVideo.AddComment(newComment);
        videosList.Add(newVideo);

        // display each video object from the List videosList
        foreach (Video eachVideo in videosList)
        {
            Console.WriteLine(eachVideo.GetDisplayText());
        }

    }
}