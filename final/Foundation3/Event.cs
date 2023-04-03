namespace Foundation3;

class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _eventAddress;

    public Event(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public void GetStandardDetails()
    {
        Console.WriteLine("Event Title: " + _eventTitle);
        Console.WriteLine("Description: " + _eventDescription);
        Console.WriteLine("Date: " + _eventDate);
        Console.WriteLine("Time: " + _eventTime);
        Console.WriteLine("Address: " + _eventAddress);
    }

    public void EventDescription(string eventType)
    {
        Console.WriteLine("Event Type: " + eventType);
        Console.WriteLine("Title: " + _eventTitle);
        Console.WriteLine("Date: " + _eventDate);
    }

}