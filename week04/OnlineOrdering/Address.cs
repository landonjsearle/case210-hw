public class Address
{
    private String _street;
    private String _city;
    private String _state;
    private String _country;


    public Address(String street, String city, String state, String country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public String DisplayAll()
    {
        String display = $"{_street} {_city}, {_state} {_country}";

        return display;
    }

    public String GetCountry()
    {
        return _country;
    }
}