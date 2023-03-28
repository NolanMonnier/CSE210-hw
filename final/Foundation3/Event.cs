using System;
public abstract class Event
{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private Address _address = null;

    public Event()
    {

    }

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public void DisplayStandard()
    {
        string _fullAddress = _address.SetFullAddress();
        System.Console.WriteLine("Standard Details:");
        System.Console.WriteLine($"Title: {_title}");
        System.Console.WriteLine($"Description: {_description}");
        System.Console.WriteLine($"Date: {_date}");
        System.Console.WriteLine($"Time: {_time}");
        System.Console.WriteLine($"Address: {_fullAddress}");
    }

    public abstract void DisplayDescription();

    public abstract void DisplayDetails();
}