public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duriation, int laps) : base(date, duriation)
    {
        _name = "Swimming";
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000;
    }

    public override double Speed()
    {
        return Math.Round((Distance() / _duration) * 60, 2);
    }

    public override double Pace()
    {
        return Math.Round(_duration / Distance(), 2);
    }

}