
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Blueberry Muffin";
        video1._length = "322";
        video1._author = "Sam Hill";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Kate Jett";
        video1Comment1._commentText = "Loooooks Sooooo gooood.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Cam Hudson";
        video1Comment2._commentText = "I love music!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Harry Potter";
        video1Comment3._commentText = "Finally!";

        Video video2 = new Video();
        video2._title = "Game On";
        video2._length = "232";
        video2._author = "Cade Showman";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Tom Trace";
        video2Comment1._commentText = "This is his best every!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Mary Beth";
        video2Comment2._commentText = "Excellent video!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Tim Will";
        video2Comment3._commentText = "I can watch this forever.";

        Video video3 = new Video();
        video3._title = "Life Is Onging";
        video3._length = "40";
        video3._author = "Andy Hop";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Amanda Pot";
        video3Comment1._commentText = "You got this!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Will Smith";
        video3Comment2._commentText = "Thank you!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Low High";
        video3Comment3._commentText = "Hope everyone sees this.";

        //add comments to list for each video 
        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);

        //add each video to videosList 
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}
