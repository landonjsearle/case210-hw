public class SwimmingAct : Activity
{
    private double _laps;

    public SwimmingAct(DateTime time, int duration, double laps)
    {
        _date = time;
        _minutes = duration;
        _laps = laps;
        _name = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() * _minutes / 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}