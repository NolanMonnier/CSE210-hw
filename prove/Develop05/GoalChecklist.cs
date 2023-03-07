using System;

public class GoalChecklist : Goal
{

    private string _name;
    private string _description;
    private int _points;
    private int _goalCount;
    private int _goalNeeded;
    private int _bonusPoints;
    private int _checklistCount;
    private string _sep = " | ";
    List<string> _goals = new List<string>();

    public GoalChecklist() : base("", "", 0)
    {

    }
    public GoalChecklist(string name,
                      string description,
                      int points,
                      int goalNeeded,
                      int bonusPoints,
                      int goalCount,
                      List<string> goals) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalCount = goalCount;
        _goalNeeded = goalNeeded;
        _goals = goals;
        _bonusPoints = bonusPoints;
    }

    public int DisplayGoalNeeded()
    {
        System.Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalNeeded = int.Parse(Console.ReadLine());
        return _goalNeeded;
    }

    public int DisplayBonusPoints()
    {
        System.Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        return _bonusPoints;
    }

    public override void AddGoal()
    {
        string line = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ") -- Currently completed: " + _checklistCount + "/" + _goalNeeded;
        _goals.Add(line);
    }
}