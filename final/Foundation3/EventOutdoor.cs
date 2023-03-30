using System;
public class EventOutdoor : Event
{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private Address _address = null;
    private string _weather = "";

    public EventOutdoor() : base()
    {

    }

    public EventOutdoor(string title,
                          string description,
                          string date,
                          string time,
                          Address address,
                          string weather) : base(title, description, time, date, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;
    }

    public override void DisplayDescription()
    {
        System.Console.WriteLine("Short Description:");
        System.Console.WriteLine("Event Type: Reception");
        System.Console.WriteLine($"Title: {_title}");
        System.Console.WriteLine($"Date: {_date}");
    }
    public override void DisplayDetails()
    {
        string _fullAddress = _address.SetFullAddress();
        System.Console.WriteLine("Full Details:");
        System.Console.WriteLine($"Title: {_title}");
        System.Console.WriteLine($"Description: {_description}");
        System.Console.WriteLine($"Date: {_date}");
        System.Console.WriteLine($"Time: {_time}");
        System.Console.WriteLine($"Address: {_fullAddress}");
        System.Console.WriteLine($"Weather: {_weather}");
    }
}