namespace Foundation4;

class BicycleActivity : Activity
{
    private double _speed;
    private double _minutes;
    public BicycleActivity(string date, string activity, double minutes, double lastParameter) : base(date, activity, minutes, lastParameter){
        _speed = lastParameter;
        _minutes = minutes;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _minutes / _speed;
    }
}