public abstract class Food
{
    public abstract void DoSomething();
}

public class Apple : Food
{
    public override void DoSomething()
    {
        Console.WriteLine("One thing.");
    }
}

public class Cherry : Food
{
    public override void DoSomething()
    {
        Console.WriteLine("Different thing");
    }
}