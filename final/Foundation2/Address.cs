
using System;

public class Address
{
    private string _streetAddress {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _country {get; set;}

    public Address (string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }

    public string GetAddress() 
    {
        return $"{_streetAddress}\r\n{_city}, {_state}\r\n{_country}";
    }
}
