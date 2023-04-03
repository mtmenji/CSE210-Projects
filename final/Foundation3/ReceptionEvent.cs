namespace Foundation3;

class ReceptionEvent: Event
{
    private string _email;
    private int _capacity;

    public ReceptionEvent(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string email) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _email = email;
    }

    public void GetReceptionDetails()
    {
        GetStandardDetails();
        Console.WriteLine("Event Type: Reception");
        Console.WriteLine("Email: " + _email);
    }

    public void GetReceptionDescription()
    {
        EventDescription("Reception");
    }
}