namespace Foundation3;

class OutdoorEvent: Event
{
    private string _weather;

    public OutdoorEvent(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string weather) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _weather = weather;
    }

    public void GetOutdoorDetails()
    {
        GetStandardDetails();
        Console.WriteLine("Event Type: Outdoor");
        Console.WriteLine("Weather: " +_weather);
    }

        public void GetOutdoorDescription()
    {
        EventDescription("Outdoor");
    }
}