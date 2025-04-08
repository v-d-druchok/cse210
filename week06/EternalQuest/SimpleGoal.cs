public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Commendations!! You have advanced yourself {GetPoints()} points, by completing this goal!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal-_-{GetName()}-_-{GetDescription()}-_-{GetPoints()}-_-{IsComplete()}";
    }
}