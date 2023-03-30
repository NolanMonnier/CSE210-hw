using System;
public class ActivitySwimming : Activity
{
    private string _date = "";
    private double _length = 0;
    private int _lap = 50;
    public override double GetSpeed(double distance)
    {
        throw new NotImplementedException();
    }

    public override double GetPace(double distance)
    {
        throw new NotImplementedException();
    }
}