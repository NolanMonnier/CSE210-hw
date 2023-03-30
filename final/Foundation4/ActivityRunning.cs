using System;
public class ActivityRunning : Activity
{
    private string _date = "";
    private double _length = 0;
    public ActivityRunning() : base()
    {

    }
    public override double GetSpeed(double distance)
    {
        throw new NotImplementedException();
    }

    public override double GetPace(double distance)
    {
        throw new NotImplementedException();
    }
}