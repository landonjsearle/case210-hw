public class Customer
{
    private String _name;
    private Address _address;

    public Customer(String name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Boolean LivesInUSA()
    {
        if ( _address.GetCountry().ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public String GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}