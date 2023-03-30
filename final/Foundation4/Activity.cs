using System;
public abstract class Activity
{
    private double _distance = 0;
    private double _minutes = 0;
    private double _speed = 0;
    private double _pace = 0;
    public Activity()
    {

    }

    public Activity(double distance, double speed, double pace)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public void GetSummary()
    {

    }

    public abstract double GetSpeed(double distance);
    public abstract double GetPace(double distance);
}