public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(String name, String description, String shards, int target, int amountCompleted, int bonus) : base(name,description,shards)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Congrats you won {_shards} Shards!");
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Amazing! For competing this goal you won {_bonus} bonus Shards!");
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override String GetDetailsString()
    {
        String details = "";
        details += base.GetDetailsString();
        details += $" --- {_amountCompleted}/{_target} | Bonus: {_bonus}";
        return details;
    }
    public override String GetStringRepresentation()
    {
        String display = "ChecklistGoal:";

        display += $"{_shortName}~{_description}~{_shards}~{_amountCompleted}~{_target}~{_bonus}";
        return display;
    }
    public override String GetShards()
    {
        int shardReturn = int.Parse(_shards);
        if (_amountCompleted == _target)
        {
            shardReturn += _bonus;
        }

        return shardReturn.ToString();
    }
}