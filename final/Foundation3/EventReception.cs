using System;
public class EventReception : Event
{
    public EventReception() : base()
    {

    }
    public EventReception(string title,
                          string description,
                          string date,
                          string time,
                          Address address,
                          string speaker,
                          int capacity) : base()
    {

    }

    public override void DisplayDescription()
    {
        throw new NotImplementedException();
    }
    public override void DisplayDetails()
    {
        throw new NotImplementedException();
    }
}