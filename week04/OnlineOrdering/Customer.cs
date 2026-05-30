using System;

// has a name and an address
// the name is a string but the address is a class
// method to return if they live in the US or not

public class Customer
{
    //attributes
    private string _name;
    private Address _address;


    // constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //method
    public string GetDisplayText()
    {
        return $"{_name}\n{_address.FullAddress()}";
    }

    public bool IsCountryUsa()
    {
        return _address.IsCountryUsa();
    }
}