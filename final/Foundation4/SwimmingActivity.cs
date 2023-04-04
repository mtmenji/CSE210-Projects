namespace Foundation4;

class SwimmingActivity : Activity
{
    private double _distance;
    public SwimmingActivity(string date, string activity, double minutes, double lastParameter) : base(date, activity, minutes, lastParameter)
    {
        _distance = lastParameter;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance * 50 / 1000 * 0.62, 2);
    }
}