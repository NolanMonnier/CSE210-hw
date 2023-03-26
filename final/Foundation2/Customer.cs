using System;
public class Customer
{
    private string _name = "";
    private Address _address = new Address();

    public Customer()
    {

    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveinUSA()
    {
        if (_address.LiveinUSA() == true)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string GetName()
    {
        return _name;
    }

}