using System;

public class GoalSimple : Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _goalCount;
    private string _sep = " | ";
    List<string> _goalsDisplay = new List<string>();
    List<string> _goalsText = new List<string>();
    private int _totalPoints;
    private bool _isCompleted = false;
    public GoalSimple() : base()
    {

    }
    public GoalSimple(string name,
                      string description,
                      int points,
                      int goalCount,
                      List<string> goalsDisplay,
                      List<string> goalsText,
                      bool isCompleted,
                      int totalPoints) : base(name, description, points, goalsDisplay, goalsText, totalPoints)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalCount = goalCount;
        _goalsDisplay = goalsDisplay;
        _goalsText = goalsText;
        _isCompleted = isCompleted;
        _totalPoints = totalPoints;
    }

    public override void AddGoal()
    {
        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";
        _goalsDisplay.Add(lineDisplay);
        string lineText = "SimpleGoal" + _sep + _name + _sep + _description + _sep + _points + _sep + _isCompleted + _sep + _goalCount;
        _goalsText.Add(lineText);
    }

    public override string AddDisplayList(string line, int goalCount)
    {
        string[] seperated = line.Split(_sep);
        _goalCount = goalCount;
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _isCompleted = bool.Parse(seperated[4]);

        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";
        return lineDisplay;
    }

    public override int RecordEvent(string[] seperated, int totalPoints)
    {
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _isCompleted = bool.Parse(seperated[4]);
        _goalCount = int.Parse(seperated[5]);
        _totalPoints = _points + totalPoints;
        System.Console.WriteLine($"Congratulations!! You have earned {_points} points!");
        System.Console.WriteLine($"You now have {_totalPoints} point.");
        return _totalPoints;
    }

    public string CheckDisplay(string[] seperated)
    {
        _name = seperated[1];
        _description = seperated[2];
        _goalCount = int.Parse(seperated[5]);
        string lineDisplay = _goalCount.ToString() + ". [X] " + _name + " (" + _description + ")";
        return lineDisplay;
    }
}