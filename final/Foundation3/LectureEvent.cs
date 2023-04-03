namespace Foundation3;

class LectureEvent: Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string speakerName, int capacity) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void GetLectureDetails()
    {
        GetStandardDetails();
        Console.WriteLine("Event Type: Lecture");
        Console.WriteLine("Speaker: " + _speakerName);
        Console.WriteLine("Capacity: " + _capacity);
    }

    public void GetLectureDescription()
    {
        EventDescription("Lecture");
    }


}