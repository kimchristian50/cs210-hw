using System;

public class CyclingActivity : Activity
{
    // attributes
    private double _speed;

    // constructor
    public CyclingActivity(DateTime date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    // methods
    public override double CalcDistance()
    {
        return _speed * _time / 60;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        return _time / CalcDistance();
    }
}