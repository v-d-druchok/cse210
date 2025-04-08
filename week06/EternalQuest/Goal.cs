public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _name;
    public int GetPoints() => _points;
    
    public string GetDescription() => _description;

    public abstract void RecordEvent();

    public abstract bool IsComplete();


    public virtual string GetDetailsString()
    {   
        return $"{GetName()} ({GetDescription()})";
    }

    public abstract string GetStringRepresentation();
}