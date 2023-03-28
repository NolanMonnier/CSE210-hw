using System;
public class EventLecture : Event
{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private Address _address = null;
    private string _speaker = "";
    private int _capacity = 0;

    public EventLecture() : base()
    {

    }

    public EventLecture(string title,
                        string description,
                        string date,
                        string time,
                        Address address,
                        string speaker,
                        int capacity) : base(title, description, time, date, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayDescription()
    {
        System.Console.WriteLine("Short Description:");
        System.Console.WriteLine("Event Type: Lecture");
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
        System.Console.WriteLine($"Speaker: {_speaker}");
        System.Console.WriteLine($"Capacity: {_capacity}");
    }
}