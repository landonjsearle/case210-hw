public class EternalGoal : Goal
{
    public EternalGoal(String name, String description, String shards) : base(name, description, shards)
    {

    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();

    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}