public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _city = city;
        _country = country;
        _state = state;
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string LiveInUsa()
    {
        if (_country.ToUpper() == "USA")
        {
            return "USA";
        }
        return _country;       
    }

    public string DisplayAddressInformation()
    {
        return $"Street Address: {_streetAddress}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }
}