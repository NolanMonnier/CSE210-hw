using System;
public class ActivityCycling : Activity
{
    private string _date = "";
    private double _distance = 0;
    private double _minutes = 0;
    private double _speed = 0;
    private double _pace = 0;

    public ActivityCycling() : base()
    {

    }

    public ActivityCycling(string date,
                           double distance,
                           double minutes,
                           double speed,
                           double pace) : base(date, distance, minutes, speed, pace)
    {
        _date = date;
        _distance = distance;
        _minutes = minutes;
        _speed = speed;
        _pace = pace;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} Cycling ({_minutes} minutes) - Distance: {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
        return summary;
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