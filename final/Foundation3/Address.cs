
using System; 

public class Address
{
    private string _streetAddress {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _postalCode {get; set;}
    private string _country {get; set;}

    public Address (string streetAddress, string city, string state, string postalCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_state} {_postalCode} {_country}";
    }
}
