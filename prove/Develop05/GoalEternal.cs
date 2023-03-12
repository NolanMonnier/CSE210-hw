using System;

public class GoalEternal : Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _goalCount;
    private string _sep = " | ";
    List<string> _goalsDisplay = new List<string>();
    List<string> _goalsText = new List<string>();
    private int _totalPoints;

    public GoalEternal() : base()
    {

    }
    public GoalEternal(string name,
                      string description,
                      int points,
                      int goalCount,
                      List<string> goalsDisplay,
                      List<string> goalsText,
                      int totalPoints) : base(name, description, points, goalsDisplay, goalsText, totalPoints)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalCount = goalCount;
        _goalsDisplay = goalsDisplay;
        _goalsText = goalsText;
        _totalPoints = totalPoints;
    }

    public override void AddGoal()
    {
        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";
        _goalsDisplay.Add(lineDisplay);
        string lineText = "EternalGoal" + _sep + _name + _sep + _description + _sep + _points + _sep + _goalCount;
        _goalsText.Add(lineText);
    }

    public override string AddDisplayList(string line, int goalCount)
    {
        string[] seperated = line.Split(_sep);
        _goalCount = goalCount;
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);

        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";

        return lineDisplay;
    }
    public override int RecordEvent(string[] seperated)
    {
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _goalCount = int.Parse(seperated[4]);
        _totalPoints = _points + _totalPoints;
        System.Console.WriteLine($"Congratulations!! You have earned {_points} points!");
        System.Console.WriteLine($"You now have {_totalPoints} point.");
        return _totalPoints;
    }
}