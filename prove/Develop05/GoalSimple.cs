using System;

public class GoalSimple : Goal
{
    private bool _isCompleted = false;
    public GoalSimple(bool isCompleted) : base(0, "", "")
    {
        _isCompleted = isCompleted;
    }
}