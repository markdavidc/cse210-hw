using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return Math.Round(speed, 2);
    }

    public override double CalculatePace()
    {
        double pace = _minutes / _distance;
        return Math.Round(pace, 2);
    }
}