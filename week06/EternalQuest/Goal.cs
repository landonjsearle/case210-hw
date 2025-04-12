public abstract class Goal
{
    protected String _shortName;
    protected String _description;
    protected String _shards;

    public Goal(String name, String description, String shards)
    {
        _shortName = name;
        _description = description;
        _shards = shards;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual String GetDetailsString()
    {
        String details = "";
        if (IsComplete() == true)
        {
            details += "[X]";
        }
        else 
        {
            details += "[ ]";
        }
        details += $" {_shortName}";
        details += $" ({_description})";
        details += $" Shards: {_shards}";
        return details;
    }
    public abstract String GetStringRepresentation();
}