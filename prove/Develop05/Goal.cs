using System;

public class Goal
{
    private int _points = 0;
    private string _name = "";
    private string _description = "";

    private string _seperator = "|";

    public Goal()
    {

    }

    public Goal(int points,
                 string name,
                 string description)
    {
        _points = points;
        _name = name;
        _description = description;
    }
}