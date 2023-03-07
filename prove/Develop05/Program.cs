using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        bool completed = false;
        int points = 0;

        while (answer < 6)
        {
            System.Console.Clear();
            System.Console.WriteLine($"You have {points} points.");
            System.Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string _menuAnswer = Console.ReadLine();
            answer = int.Parse(_menuAnswer);
        }


        GoalSimple goalSimple = new GoalSimple(completed);
    }
}