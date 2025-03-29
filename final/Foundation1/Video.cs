using System;

public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _commentList = new List<Comment>();

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        int commentCount = _commentList.Count();
        Console.WriteLine($"Comments ({commentCount}):");

        foreach (Comment comment in _commentList)
        {
            comment.DisplayComment();
        }

    }
}