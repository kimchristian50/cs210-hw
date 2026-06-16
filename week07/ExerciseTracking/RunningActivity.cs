using System;

public class RunningActivity : Activity
{
    // attributes
    private double _distance;

    // constructor
    public RunningActivity(DateTime date, double time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    // methods
    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        return (_distance / _time) * 60;
    }

    public override double CalcPace()
    {
        return _time / _distance;
    }
}