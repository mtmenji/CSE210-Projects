namespace Foundation3;

class Address {
    private string _address;
    public Address(string address)
    {
        _address = address;
    }
    public string GetAddress()
    {
        return _address;
    }
}