using System;

public abstract class Goal
{
    private int _points = 0;
    private string _name = "";
    private string _description = "";
    List<string> _goalsText = new List<string>();
    List<string> _goalsDisplay = new List<string>();
    private int goalCount = 1;
    private int _totalPoints;

    public Goal()
    {

    }

    public Goal(string name,
                string description,
                int points,
                List<string> goalsDisplay,
                List<string> goalsText,
                int totalPoints)

    {
        _points = points;
        _name = name;
        _description = description;
        _goalsDisplay = goalsDisplay;
        _goalsText = goalsText;
        _totalPoints = totalPoints;
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

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(string.Join(Environment.NewLine, _goalsText));

        }
    }

    public List<string> LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            if (line.Contains("SimpleGoal"))
            {
                _goalsText.Add(line);
                GoalSimple simple = new GoalSimple();
                string goal = simple.AddDisplayList(line, goalCount);
                _goalsDisplay.Add(goal);
                goalCount++;
            }
            if (line.Contains("EternalGoal"))
            {
                _goalsText.Add(line);
                GoalEternal eternal = new GoalEternal();
                string goal = eternal.AddDisplayList(line, goalCount);
                _goalsDisplay.Add(goal);
                goalCount++;
            }
            if (line.Contains("ChecklistGoal"))
            {
                _goalsText.Add(line);
                GoalChecklist checklist = new GoalChecklist();
                string goal = checklist.AddDisplayList(line, goalCount);
                _goalsDisplay.Add(goal);
                goalCount++;
            }
        }

        return _goalsDisplay;
    }

    public int RecordEvent()
    {
        System.Console.WriteLine("The goals are:");

        foreach (string goal in _goalsDisplay)
        {
            System.Console.WriteLine(goal);
        }
        System.Console.Write("Which goal did you accomplish? ");
        int recordAnswer = int.Parse(Console.ReadLine());
        foreach (string goal in _goalsText)
        {
            string[] seperated = goal.Split("|");
            int itemCount = seperated.Length;
            if (recordAnswer == int.Parse(seperated[itemCount - 1]))
            {
                if (goal.Contains("SimpleGoal"))
                {
                    GoalSimple simple = new GoalSimple();
                    _totalPoints = simple.RecordEvent();
                }
                if (goal.Contains("EternalGoal"))
                {
                    GoalEternal eternal = new GoalEternal();
                    _totalPoints = eternal.RecordEvent(seperated);
                }
            }
        }
        return _totalPoints;
    }

    public int SetCount()
    {
        return goalCount;
    }

    public abstract void AddGoal();
    public abstract string AddDisplayList(string line, int goalCount);
    public abstract int RecordEvent(string[] line);
}