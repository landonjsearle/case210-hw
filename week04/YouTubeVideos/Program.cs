using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Comment set1C1 = new Comment("Fred", "I want more of dis stuffs.");
        Comment set1C2 = new Comment("Susan", "You need to do better next time.");
        Comment set1C3 = new Comment("Ralph", "Clikc to buy now!");
        List<Comment> comments1 = new List<Comment>();
        comments1.Add(set1C1);
        comments1.Add(set1C2);
        comments1.Add(set1C3);
        Video video1 = new Video("Landon", "How to make tacos in record time", 85623, comments1);

        Comment set2C1 = new Comment("Jack", "I need this.");
        Comment set2C2 = new Comment("Jane", "Neet");
        Comment set2C3 = new Comment("Judi", "Cool. Can i do this too?");
        List<Comment> comments2 = new List<Comment>();
        comments2.Add(set2C1);
        comments2.Add(set2C2);
        comments2.Add(set2C3);
        Video video2 = new Video("Jordan", "How to brush your teeth upsidedown!", 3665, comments2);

        Comment set3C1 = new Comment("James", "I don't like comments.");
        Comment set3C2 = new Comment("Franny", "This is a place holder comment");
        Comment set3C3 = new Comment("John", "What day is it?");
        List<Comment> comments3 = new List<Comment>();
        comments3.Add(set3C1);
        comments3.Add(set3C2);
        comments3.Add(set3C3);
        Video video3 = new Video("Joey", "Hotdog eating contest: NEW RECORD", 25, comments3);

        List<Video> videoList = new List<Video>();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            int numComments = video.ReturnCommentNumber();
            String vidDisplay = video.GetDisplay();
            
            Console.WriteLine($"{vidDisplay} Number of Comments: {numComments}.");
        }

    }
}