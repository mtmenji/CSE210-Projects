using System;
namespace Foundation4;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity("03 Nov 2022", "Running", 35, 3);
        activities.Add(running);

        BicycleActivity biking = new BicycleActivity("04 Dec 2023", "Biking", 24, 5);
        activities.Add(biking);

        SwimmingActivity swimming = new SwimmingActivity("05 Jan 2024", "Swimming", 88, 600);
        activities.Add(swimming);

        foreach(var activity in activities)
        {
            activity.GetSummary();
        }
    }
}