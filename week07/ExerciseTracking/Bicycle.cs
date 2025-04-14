public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(string date, int duriation, int speed) : base(date, duriation)
    {
        _name = "Cycling";
        _speed = speed;
    }

    public override double Distance()
    {
        return Math.Round(_speed * (_duration / 60), 2);
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return Math.Round(60 / _speed, 2);
    }
}
