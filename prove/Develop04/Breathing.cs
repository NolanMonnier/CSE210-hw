using System;

public class Breathing : Activity
{
    private string _breathIn = "";
    private string _breathOut = "";
    private string _activityName = "Breathing Activity.";

    public Breathing(string startingMessage, int timerLength, string endingMessage, string spinner) : base(startingMessage, timerLength, endingMessage, spinner)
    {
        Console.WriteLine($"{startingMessage}{_activityName}");
    }
}