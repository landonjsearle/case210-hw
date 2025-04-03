public class WrittingAssignment : Assignment
{
    private String _title;

    public WrittingAssignment(String name, String topic, String title) : base(name, topic)
    {
        _title = title;
    }

    public String GetWrittingInfo()
    {
        return $"{_title} by {GetName()}";
    }
}