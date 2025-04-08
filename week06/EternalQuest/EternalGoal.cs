public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override void RecordEvent()
    {
        Console.WriteLine($"I applaud!! You have advanced yourself {GetPoints()} points, by once again sticking to your goal!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal-_-{GetName()}-_-{GetDescription()}-_-{GetPoints()}";
    }
}