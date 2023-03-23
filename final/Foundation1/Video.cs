using System;
public class Video
{
    private string _title = "";
    private string _author = "";
    private double _length = 0;
    private int _commentCount = 0;
    private string _name = "";
    private string _comment = "";
    private List<string> _commentList = new List<string>();
    private List<string> _videoList = new List<string>();

    public Video()
    {

    }
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;

    }
    public void AddVideo(string video)
    {
        _videoList.Add(video);
    }

    public void AddComment(string name, string comment)
    {
        _name = name;
        _comment = comment;
        _commentList.Add($"{_name}: {_comment}");
        //_videoList.Add($"{_name}: {_comment}");
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
        foreach (string comment in _commentList)
        {
            Comment newComment = new Comment(comment);
            newComment.Display();
        }
        System.Console.WriteLine($"Amount of Comments: {_commentCount}");

        //foreach (string video in _videoList)
        //{
        //    System.Console.WriteLine(video);
        //}

    }
}