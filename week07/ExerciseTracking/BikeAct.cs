public class BikeAct : Activity
{
    private double _speed;

    public BikeAct(DateTime time, int duration, double speed)
    {
        _date = time;
        _minutes = duration;
        _speed = speed;
        _name = "Biking";
    }

    public override double GetDistance()
    {
        return _speed * _minutes;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}