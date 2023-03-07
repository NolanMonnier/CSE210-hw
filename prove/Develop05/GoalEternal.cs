using System;

public class GoalEternal : Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _goalCount;
    private string _sep = " | ";
    List<string> _goals = new List<string>();

    public GoalEternal() : base("", "", 0)
    {

    }
    public GoalEternal(string name,
                      string description,
                      int points,
                      int goalCount,
                      List<string> goals) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalCount = goalCount;
        _goals = goals;
    }

    public override void AddGoal()
    {
        string line = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";
        _goals.Add(line);
    }
}