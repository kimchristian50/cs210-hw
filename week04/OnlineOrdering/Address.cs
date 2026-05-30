using System;
using System.Reflection.Metadata.Ecma335;

// contains a string for the street address, city, state/province, country
// method to return whether or not it's in the US
// method to return a string of all of its fields together in one string (with newline characters)

public class Address
{
    // attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // constructors
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // methods

    public string FullAddress()
    {
        string address = $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
        return address;
    }

    public bool IsCountryUsa()
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
}