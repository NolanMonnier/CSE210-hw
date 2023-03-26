using System;
public class Comment
{
    private string _comment = "";
    private string _name = "";

    public Comment(string comment, string name)
    {
        _comment = comment;
        _name = name;
    }

    public void Display()
    {
        System.Console.WriteLine($"{_comment}: {_name}");
    }
}