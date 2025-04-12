public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(String name, String description, String shards) : base(name, description, shards)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;      
        Console.WriteLine($"Comgrats! You have won {_shards} shards!");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        String code = "SimpleGoal:";
        code += $"{_shortName}~{_description}~{_shards}~{_isComplete}";
        return code;
    }
}