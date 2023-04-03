using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<string> _activitiesList = new List<string>();
        //------------------ RUNNING ------------------
        ActivityRunning runningSample = new ActivityRunning();
        double runningSpeed = runningSample.GetSpeed(5.3, 35);
        double runningPace = runningSample.GetPace(5.3, 35);
        ActivityRunning running = new ActivityRunning("03 Apr 2023", 5.3, 35, runningSpeed, runningPace);
        string finalRunning = running.GetSummary();
        _activitiesList.Add(finalRunning);

        //------------------ Cycling ------------------
        ActivityCycling cyclingSample = new ActivityCycling();
        double cyclingSpeed = cyclingSample.GetSpeed(10, 30);
        double cyclingPace = cyclingSample.GetPace(10, 30);
        ActivityCycling cycling = new ActivityCycling("05 Apr 2023", 10, 30, cyclingSpeed, cyclingPace);
        string finalCycling = cycling.GetSummary();
        _activitiesList.Add(finalCycling);

        //------------------ SWIMMING ------------------
        ActivitySwimming swimmingSample = new ActivitySwimming();
        double swimmingDistance = swimmingSample.GetDistance(40, 30);
        double swimmingSpeed = swimmingSample.GetSpeed(swimmingDistance, 30);
        double swimmingPace = swimmingSample.GetPace(swimmingDistance, 30);
        ActivitySwimming swimming = new ActivitySwimming("10 Apr 2023", swimmingDistance, 30, swimmingSpeed, swimmingPace, 40);
        string finalSwimming = swimming.GetSummary();
        _activitiesList.Add(finalSwimming);

        foreach (string activity in _activitiesList)
        {
            System.Console.WriteLine(activity);
        }
    }
}