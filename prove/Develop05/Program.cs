using System;

class Program
{
    static void Main(string[] args)
    {
        //To exceed the requirements, I added a "Negative Goal" that essentially 
        //works as an eternal goal but will negatively impact the total points. 
        //For example, if the user says that skipping class will cost them 50 
        //points when they record it, the total points will be 50 points lower. 
        int answer = 0;
        bool completed = false;
        int totalPoints = 0;
        int _goalAnswer = 0;
        string name = "";
        string description = "";
        int points = 0;
        int goalCount = 1;
        int goalNeeded = 0;
        int bonusPoints = 0;
        List<string> goalsDisplay = new List<string>();
        List<string> goalsText = new List<string>();
        goalsText.Add(totalPoints.ToString());
        GoalSimple simple = new GoalSimple(name, description, points, goalCount, goalsDisplay, goalsText, completed, totalPoints);

        Console.Clear();

        while (answer < 6)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"You have {totalPoints} points.");
            System.Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string _menuAnswer = Console.ReadLine();
            answer = int.Parse(_menuAnswer);

            if (answer == 1)
            {
                System.Console.WriteLine("The types of goals are:");
                System.Console.WriteLine(" 1. Simple Goal");
                System.Console.WriteLine(" 2. Eternal Goal");
                System.Console.WriteLine(" 3. Checklist Goal");
                System.Console.WriteLine(" 4. Negative Goal");
                System.Console.Write("Which type of goal would you like to create? ");
                string _stringGoalAnswer = Console.ReadLine();
                _goalAnswer = int.Parse(_stringGoalAnswer);

                if (_goalAnswer == 1)
                {
                    GoalSimple simpleIntro = new GoalSimple();
                    name = simpleIntro.DisplayNameIntro();
                    description = simpleIntro.DisplayDescIntro();
                    points = simpleIntro.DisplayPointsIntro();

                    GoalSimple simpleGoal = new GoalSimple(name, description, points, goalCount, goalsDisplay, goalsText, completed, totalPoints);
                    simpleGoal.AddGoal();
                    goalCount++;
                }
                if (_goalAnswer == 2)
                {
                    GoalEternal eternalIntro = new GoalEternal();
                    name = eternalIntro.DisplayNameIntro();
                    description = eternalIntro.DisplayDescIntro();
                    points = eternalIntro.DisplayPointsIntro();

                    GoalEternal eternalGoal = new GoalEternal(name, description, points, goalCount, goalsDisplay, goalsText, totalPoints);
                    eternalGoal.AddGoal();
                    goalCount++;
                }
                if (_goalAnswer == 3)
                {
                    GoalChecklist checklistIntro = new GoalChecklist();
                    name = checklistIntro.DisplayNameIntro();
                    description = checklistIntro.DisplayDescIntro();
                    points = checklistIntro.DisplayPointsIntro();
                    goalNeeded = checklistIntro.DisplayGoalNeeded();
                    bonusPoints = checklistIntro.DisplayBonusPoints();

                    GoalChecklist checklistGoal = new GoalChecklist(name, description, points, goalNeeded, bonusPoints, goalCount, goalsDisplay, goalsText, totalPoints);
                    checklistGoal.AddGoal();
                    goalCount++;
                }
                if (_goalAnswer == 4)
                {
                    GoalNegative negativeIntro = new GoalNegative();
                    name = negativeIntro.DisplayNameIntro();
                    description = negativeIntro.DisplayDescIntro();
                    points = negativeIntro.DisplayPointsIntroNeg();

                    GoalNegative negativeGoal = new GoalNegative(name, description, points, goalCount, goalsDisplay, goalsText, totalPoints);
                    negativeGoal.AddGoal();
                    goalCount++;
                }
            }

            if (answer == 2)
            {
                System.Console.WriteLine("The goals are:");

                foreach (string goal in goalsDisplay)
                {
                    System.Console.WriteLine(goal);
                }
            }

            if (answer == 3)
            {
                simple.SaveGoals(goalsText);
            }

            if (answer == 4)
            {
                goalsDisplay = simple.LoadGoals();
                goalCount = simple.SetCount();
                totalPoints = simple.SetTotal();
            }

            if (answer == 5)
            {
                System.Console.WriteLine("The goals are:");

                foreach (string goal in goalsDisplay)
                {
                    System.Console.WriteLine(goal);
                }
                System.Console.Write("Which goal did you accomplish? ");
                int recordAnswer = int.Parse(Console.ReadLine());
                totalPoints = simple.RecordEvent(totalPoints, recordAnswer, goalsText);
                goalsText[0] = totalPoints.ToString();
                List<string> newGoalsText = new List<string>();

                foreach (string goal in goalsText)
                {
                    string[] seperated = goal.Split("|");
                    int itemCount = seperated.Length;
                    if (recordAnswer == int.Parse(seperated[itemCount - 1]))
                    {
                        if (goal.Contains("SimpleGoal"))
                        {
                            goalsDisplay[recordAnswer - 1] = simple.ChangeDisplay(seperated);
                            newGoalsText.Add(simple.ChangeText(goal, recordAnswer));
                        }
                        else if (goal.Contains("EternalGoal"))
                        {
                            GoalEternal eternal = new GoalEternal();
                            goalsDisplay[recordAnswer - 1] = eternal.ChangeDisplay(seperated);
                            newGoalsText.Add(eternal.ChangeText(goal, recordAnswer));
                        }
                        else if (goal.Contains("ChecklistGoal"))
                        {
                            GoalChecklist checklist = new GoalChecklist();
                            goalsDisplay[recordAnswer - 1] = checklist.ChangeDisplay(seperated);
                            newGoalsText.Add(checklist.ChangeText(goal, recordAnswer));
                        }
                        else if (goal.Contains("NegativeGoal"))
                        {
                            GoalNegative negative = new GoalNegative();
                            goalsDisplay[recordAnswer - 1] = negative.ChangeDisplay(seperated);
                            newGoalsText.Add(negative.ChangeText(goal, recordAnswer));
                        }
                    }
                    else
                    {
                        newGoalsText.Add(goal);
                    }
                }
                goalsText = newGoalsText;
                recordAnswer = 0;
            }

            if (answer >= 6)
            {
                System.Console.WriteLine("Quitting...");
            }
        }
    }
}