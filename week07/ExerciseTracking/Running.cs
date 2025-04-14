public class Running : Activity
{
    private double _distance;

    public Running(string date, int duriation, double distance) : base(date, duriation)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return Math.Round((_distance / _duration) * 60, 2);
    }

    public override double Pace()
    {
        return Math.Round(_duration / _distance, 2);
    }

}