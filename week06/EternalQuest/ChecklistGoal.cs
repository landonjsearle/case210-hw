public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(String name, String description, String shards, int target, int bonus) : base(name,description,shards)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override String GetDetailsString()
    {
        throw new NotImplementedException();
    }
    public override String GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}