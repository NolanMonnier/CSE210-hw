using System;
public class ActivitySwimming : Activity
{
    private string _date = "";
    private double _distance = 0;
    private double _minutes = 0;
    private double _speed = 0;
    private double _pace = 0;
    private int _lapLength = 50;
    private double _swimmingLaps = 0;

    public ActivitySwimming() : base()
    {

    }

    public ActivitySwimming(string date,
                            double distance,
                            double minutes,
                            double speed,
                            double pace,
                            double swimmingLaps) : base(date, distance, minutes, speed, pace)
    {
        _date = date;
        _distance = distance;
        _minutes = minutes;
        _speed = speed;
        _pace = pace;
        _swimmingLaps = swimmingLaps;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} Swimming ({_minutes} minutes) - Lap Count: {_swimmingLaps} - Distance: {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
        return summary;
    }

    public double GetDistance(double _swimmingLaps, double minutes)
    {
        _distance = _swimmingLaps * _lapLength / 1000;
        return Math.Round(_distance, 2);
    }

    public override double GetSpeed(double distance, double minutes)
    {
        double _speed = 0;
        _speed = (distance / minutes) * 60;
        return Math.Round(_speed, 2);
    }

    public override double GetPace(double distance, double minutes)
    {
        double _pace = 0;
        _pace = minutes / distance;
        return Math.Round(_pace, 2);
    }
}