public abstract class Activity
{
    protected string _name;
    protected string _date;
    protected int _duration;

    public Activity(string date, int duriation)
    {
        _date = date;
        _duration = duriation;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public string GetSummary()
    {
        return $"{_date} {_name} ({_duration} min)- Distance: {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km.";
    }
}