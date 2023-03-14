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
    private string _loadFileName;

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

    public void SaveGoals(List<string> goalsText)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(string.Join(Environment.NewLine, goalsText));

        }
    }

    public List<string> LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        _loadFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_loadFileName);
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

    public int SetTotal()
    {
        string[] lines = System.IO.File.ReadAllLines(_loadFileName);

        _totalPoints = int.Parse(lines[0]);
        return _totalPoints;
    }

    public int RecordEvent(int totalPoints, int recordAnswer, List<string> goalsText)
    {
        foreach (string goal in goalsText)
        {
            string[] seperated = goal.Split("|");
            int itemCount = seperated.Length;
            if (recordAnswer == int.Parse(seperated[itemCount - 1]))
            {
                if (goal.Contains("SimpleGoal"))
                {
                    GoalSimple simple = new GoalSimple();
                    _totalPoints = simple.RecordEvent(seperated, totalPoints, goalsText);
                }
                if (goal.Contains("EternalGoal"))
                {
                    GoalEternal eternal = new GoalEternal();
                    _totalPoints = eternal.RecordEvent(seperated, totalPoints, goalsText);
                }
                if (goal.Contains("ChecklistGoal"))
                {
                    GoalChecklist checklist = new GoalChecklist();
                    _totalPoints = checklist.RecordEvent(seperated, totalPoints, goalsText);

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
    public abstract int RecordEvent(string[] line, int totalPoints, List<string> goalsText);
    public abstract string ChangeDisplay(string[] seperated);
    public abstract string ChangeText(string line, int goalCount);
}