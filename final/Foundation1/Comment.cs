using System;
public class Comment
{
    private string _comment = "";

    public Comment(string comment)
    {
        _comment = comment;
    }

    public void Display()
    {
        System.Console.WriteLine($"{_comment}");
    }
}