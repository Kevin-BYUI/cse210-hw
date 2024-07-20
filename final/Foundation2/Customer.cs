public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _address = address;
        _customerName = customerName;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }

    public string CountryOfResidence()
    {
        if (_address.LiveInUsa() == "USA")
        {
            return $"USA";
            
        }
        return $"{_address.GetCountry()}";      
    }

    public string DisplayCustomerInformation()
    
    {
        return $"Name: {_customerName}\nAddress Details:\n{_address.DisplayAddressInformation()}";
    }
}