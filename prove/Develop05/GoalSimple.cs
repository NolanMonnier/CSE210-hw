using System;

public class GoalSimple : Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _goalCount;
    private string _sep = " | ";
    List<string> _goals = new List<string>();

    private bool _isCompleted = false;
    public GoalSimple() : base("", "", 0)
    {

    }
    public GoalSimple(string name,
                      string description,
                      int points,
                      int goalCount,
                      List<string> goals,
                      bool isCompleted) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalCount = goalCount;
        _goals = goals;
        _isCompleted = isCompleted;
    }

    public override void AddGoal()
    {
        string line = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";
        _goals.Add(line);
    }
}