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
    List<string> _goalsDisplay = new List<string>();
    List<string> _goalsText = new List<string>();
    private int _totalPoints;

    public GoalChecklist() : base()
    {

    }
    public GoalChecklist(string name,
                      string description,
                      int points,
                      int goalNeeded,
                      int bonusPoints,
                      int goalCount,
                      List<string> goalsDisplay,
                      List<string> goalsText,
                      int totalPoints) : base(name, description, points, goalsDisplay, goalsText, totalPoints)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalCount = goalCount;
        _goalNeeded = goalNeeded;
        _goalsDisplay = goalsDisplay;
        _goalsText = goalsText;
        _bonusPoints = bonusPoints;
        _totalPoints = totalPoints;
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
        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ") -- Currently completed: " + _checklistCount + "/" + _goalNeeded;
        _goalsDisplay.Add(lineDisplay);
        string lineText = "ChecklistGoal" + _sep + _name + _sep + _description + _sep + _points + _sep + _bonusPoints + _sep + _goalNeeded + _sep + _checklistCount + _sep + _goalCount;
        _goalsText.Add(lineText);
    }
    public override string AddDisplayList(string line, int goalCount)
    {
        string[] seperated = line.Split(_sep);
        _goalCount = goalCount;
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _bonusPoints = int.Parse(seperated[4]);
        _goalNeeded = int.Parse(seperated[5]);
        _checklistCount = int.Parse(seperated[6]);

        string lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ") -- Currently completed: " + _checklistCount + "/" + _goalNeeded;
        return lineDisplay;
    }
    public override int RecordEvent(string[] seperated, int totalPoints, List<string> goalsText)
    {
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _bonusPoints = int.Parse(seperated[4]);
        _goalNeeded = int.Parse(seperated[5]);
        _checklistCount = int.Parse(seperated[6]) + 1;
        _goalCount = int.Parse(seperated[7]);

        if (_checklistCount == _goalNeeded)
        {
            _totalPoints = totalPoints + _points + _bonusPoints;
            System.Console.WriteLine($"Congratulations!! You have earned {_points + _bonusPoints} points!");
            System.Console.WriteLine($"You now have {_totalPoints} point.");
        }
        if (_checklistCount < _goalNeeded)
        {
            _totalPoints = _points + totalPoints;
            System.Console.WriteLine($"Congratulations!! You have earned {_points} points!");
            System.Console.WriteLine($"You now have {_totalPoints} point.");
        }
        return _totalPoints;
    }

    public override string ChangeDisplay(string[] seperated)
    {
        string lineDisplay = "";
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _bonusPoints = int.Parse(seperated[4]);
        _goalNeeded = int.Parse(seperated[5]);
        _checklistCount = int.Parse(seperated[6]) + 1;
        _goalCount = int.Parse(seperated[7]);
        if (_checklistCount < _goalNeeded)
        {
            lineDisplay = _goalCount.ToString() + ". [ ] " + _name + " (" + _description + ") -- Currently completed: " + _checklistCount + "/" + _goalNeeded;
        }
        if (_checklistCount >= _goalNeeded)
        {
            lineDisplay = _goalCount.ToString() + ". [X] " + _name + " (" + _description + ") -- Currently completed: " + _checklistCount + "/" + _goalNeeded;
        }
        return lineDisplay;
    }

    public override string ChangeText(string line, int goalCount)
    {
        string[] seperated = line.Split(_sep);
        _goalCount = goalCount;
        _name = seperated[1];
        _description = seperated[2];
        _points = int.Parse(seperated[3]);
        _bonusPoints = int.Parse(seperated[4]);
        _goalNeeded = int.Parse(seperated[5]);
        _checklistCount = int.Parse(seperated[6]) + 1;
        string textDisplay = "ChecklistGoal" + _sep + _name + _sep + _description + _sep + _points + _sep + _bonusPoints + _sep + _goalNeeded + _sep + _checklistCount + _sep + _goalCount;
        return textDisplay;
    }
}