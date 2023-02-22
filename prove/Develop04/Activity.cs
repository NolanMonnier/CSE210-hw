using System;

public class Activity
{
    private string _startingMessage = "Welcome to the ";
    private int _timerLength;
    private string _endingMessage = "";
    private string _spinner = "";

    public Activity(string startingMessage, int timerLength, string endingMessage, string spinner)
    {
        _startingMessage = startingMessage;
        _timerLength = timerLength;
        _endingMessage = endingMessage;
        _spinner = spinner;
    }

}