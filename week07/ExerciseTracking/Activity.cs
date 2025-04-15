public abstract class Activity
{
    protected DateTime _date = new DateTime();
    protected int _minutes;
    protected String _name;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public String GetSummary()
    {
        String display = $"{_date.ToString()} ({_minutes}) {_name}: Distance - {GetDistance()} km, Speed - {GetSpeed()} kph, Pace - {GetPace()} min per km";

        return display;
    }

}