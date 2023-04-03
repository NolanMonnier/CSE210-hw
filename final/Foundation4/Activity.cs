using System;
public abstract class Activity
{
    private string _date = "";
    private double _distance = 0;
    private double _minutes = 0;
    private double _speed = 0;
    private double _pace = 0;
    public Activity()
    {

    }

    public Activity(string date, double distance, double minutes, double speed, double pace)
    {
        _date = date;
        _distance = distance;
        _minutes = minutes;
        _speed = speed;
        _pace = pace;
    }

    public abstract string GetSummary();
    public abstract double GetSpeed(double distance, double minutes);
    public abstract double GetPace(double distance, double minutes);
}