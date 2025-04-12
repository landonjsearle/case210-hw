public class EternalGoal : Goal
{
    public EternalGoal(String name, String description, String shards) : base(name, description, shards)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congrats! You won {_shards} Shards!");
    }
    public override bool IsComplete()
    {
        return false; // This goal will never be completed
    }
    public override string GetStringRepresentation()
    {
        String code = "EternalGoal:";
        code += $"{_shortName}~{_description}~{_shards}";
        return code;
    }
}