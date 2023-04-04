namespace Foundation4;

class Activity
{
    private string _date;
    private string _activity;
    private double _minutes;
    private double _lastParameter;
    public Activity(string date, string activity, double minutes, double lastParameter)
    {
        _date = date;
        _activity = activity;
        _minutes = minutes;
        _lastParameter = lastParameter;
    }

    public virtual double GetDistance()
    {
        return _lastParameter;
    }

    public virtual double GetSpeed()
    {
        return Math.Round((GetDistance() / _minutes) * 60, 2);
    }

    public virtual double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activity} ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}