using System;

public class Activity
{
    private string _startingMessage = "";
    private string _description = "";
    private string _name = "";
    private int _activityLength = 0;
    private string _endingMessage = "Well Done!";

    //private string _spinner = "";

    public Activity()
    {

    }

    public Activity(string startingMessage,
                    string description,
                    string name,
                    int activityLength,
                    string endingMessage)
    {
        _startingMessage = startingMessage;
        _description = description;
        _name = name;
        _activityLength = activityLength;
        _endingMessage = endingMessage;
    }

    public int DisplayIntro()
    {
        Console.Clear();
        System.Console.WriteLine(_startingMessage);
        System.Console.WriteLine(" ");
        System.Console.WriteLine(_description);
        System.Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session? ");
        string timeranswer = Console.ReadLine();
        _activityLength = int.Parse(timeranswer);

        Console.Clear();
        System.Console.WriteLine("Get Ready...");
        DisplaySpinner(3);
        System.Console.WriteLine(" ");

        return _activityLength;
    }

    public void DisplayEnding()
    {
        System.Console.WriteLine(_endingMessage);
        DisplaySpinner(3);
        System.Console.WriteLine();
        System.Console.WriteLine($"You have completed another {_activityLength} seconds of the {_name} Activity.");
        DisplaySpinner(3);
    }

    public void DisplaySpinner(int delay)
    {
        int delta = 300;
        double time = delay * 1000;
        while (time > 0)
        {
            Console.Write("|");

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b \b");
        }
    }

    public void DisplayTimer(int timer)
    {
        while (timer > 0)
        {
            System.Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timer--;
        }
    }

}