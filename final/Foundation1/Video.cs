using System;
public class Video
{
    private string _title = "";
    private string _author = "";
    private double _length = 0;
    private int _commentCount = 0;
    private List<Comment> _commentList = new List<Comment>();

    public Video()
    {

    }
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
        _commentCount++;
    }

    public int CountComments()
    {
        return _commentCount;
    }

    public void Display()
    {
        System.Console.WriteLine($"Title: {_title}");
        System.Console.WriteLine($"Author: {_author}");
        System.Console.WriteLine($"Length: {_length} seconds");
        foreach (Comment comment in _commentList)
        {
            comment.Display();
        }
        System.Console.WriteLine($"Amount of Comments: {_commentCount}");

    }
}