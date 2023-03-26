using System;
public class Address
{
    private string _street = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _country = "";
    private string _fullAddress = "";

    public Address()
    {

    }

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool LiveinUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string FullAddress()
    {
        _fullAddress = _street + "\n" + _city + ", " + _stateProvince + "\n" + _country;
        return _fullAddress;
    }
}