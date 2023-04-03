using System;
namespace Foundation3;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 OneTwo Street, Las Vegas, New York");
        Address address2 = new Address("456 FourFive Drive, Rexburg, Utah");
        Address address3 = new Address("789 SevenEight Road, Houston, Oklahoma");

        LectureEvent event1 = new LectureEvent("Intro Seminar", "Learning the basics", "Jan 3", "1500", address1, "Gary Smith", 200);
        event1.GetStandardDetails();
        event1.GetLectureDetails();
        event1.GetLectureDescription();

        Console.WriteLine("---------------------------------------------");

        OutdoorEvent event2 = new OutdoorEvent("Ward Picnic", "Grill in the park! Games and Family Fun!", "July 3", "1230", address2, "Sunny");
        event2.GetStandardDetails();
        event2.GetOutdoorDetails();
        event2.GetOutdoorDescription();

        Console.WriteLine("---------------------------------------------");

        ReceptionEvent event3 = new ReceptionEvent("Michael and Hailey Wedding", "Come show love to the newly weds!", "Aug 28", "1700", address3, "mikeymenji@gmail.com");
        event3.GetStandardDetails();
        event3.GetReceptionDetails();
        event3.GetReceptionDescription();
    }
}