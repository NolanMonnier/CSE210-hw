using System;

class Program
{
    static void Main(string[] args)
    {
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
        int checklistCount = 0;
        List<string> goals = new List<string>();

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
                System.Console.Write("Which type of goal would you like to create? ");
                string _stringGoalAnswer = Console.ReadLine();
                _goalAnswer = int.Parse(_stringGoalAnswer);

                if (_goalAnswer == 1)
                {
                    GoalSimple simpleIntro = new GoalSimple();
                    name = simpleIntro.DisplayNameIntro();
                    description = simpleIntro.DisplayDescIntro();
                    points = simpleIntro.DisplayPointsIntro();

                    GoalSimple simpleGoal = new GoalSimple(name, description, points, goalCount, goals, completed);
                    simpleGoal.AddGoal();
                    goalCount++;
                }
                if (_goalAnswer == 2)
                {
                    GoalEternal eternalIntro = new GoalEternal();
                    name = eternalIntro.DisplayNameIntro();
                    description = eternalIntro.DisplayDescIntro();
                    points = eternalIntro.DisplayPointsIntro();

                    GoalEternal eternalGoal = new GoalEternal(name, description, points, goalCount, goals);
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

                    GoalChecklist checklistGoal = new GoalChecklist(name, description, points, goalNeeded, bonusPoints, goalCount, goals);
                    checklistGoal.AddGoal();
                    goalCount++;
                }
            }

            if (answer == 2)
            {
                System.Console.WriteLine("The goals are:");

                foreach (string goal in goals)
                {
                    System.Console.WriteLine(goal);
                }
            }
        }



    }
}