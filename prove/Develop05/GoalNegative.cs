using System;

public class GoalNegative : Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _goalCount;
    private string _sep = " | ";
    List<string> _goalsDisplay = new List<string>();
    List<string> _goalsText = new List<string>();
    private int _totalPoints;

    public GoalNegative() : base()
    {

    }
    public GoalNegative(string name,
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

    public int DisplayPointsIntroNeg()
    {
        System.Console.Write("What is the number of points associated with this goal? (Please enter as a positive integer) ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public override void AddGoal()
    {
        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";
        _goalsDisplay.Add(lineDisplay);
        string lineText = "NegativeGoal" + _sep + _name + _sep + _description + _sep + _points + _sep + _goalCount;
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
    public override int RecordEvent(string[] seperated, int totalPoints, List<string> goalsText)
    {
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _goalCount = int.Parse(seperated[4]);
        _totalPoints = totalPoints - _points;
        System.Console.WriteLine($"Oh no... You have lost {_points} points...");
        System.Console.WriteLine($"You now have {_totalPoints} point.");
        return _totalPoints;
    }

    public override string ChangeDisplay(string[] seperated)
    {
        _name = seperated[1];
        _description = seperated[2];
        _goalCount = int.Parse(seperated[4]);
        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ")";
        return lineDisplay;
    }

    public override string ChangeText(string line, int goalCount)
    {
        string[] seperated = line.Split(_sep);
        _goalCount = goalCount;
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        string textDisplay = "NegativeGoal" + _sep + _name + _sep + _description + _sep + _points + _sep + _goalCount;
        return textDisplay;
    }
}