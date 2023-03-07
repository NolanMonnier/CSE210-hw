using System;

public abstract class Goal
{
    private int _points = 0;
    private string _name = "";
    private string _description = "";

    public Goal()
    {

    }

    public Goal(string name,
                string description,
                int points)

    {
        _points = points;
        _name = name;
        _description = description;
    }

    public string DisplayNameIntro()
    {
        System.Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }
    public string DisplayDescIntro()
    {
        System.Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }
    public int DisplayPointsIntro()
    {
        System.Console.Write("What is the number of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public abstract void AddGoal();
}