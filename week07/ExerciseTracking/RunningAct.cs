public class RunningAct : Activity
{
    private double _distance;

    public RunningAct(DateTime time, int duration, double distance)
    {
        _distance = distance;
        _minutes = duration;
        _date = time;
        _name = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
}