using System;

public class SwimmingActivity : Activity
{
    // attributes
    private double _laps;

    // constructor
    public SwimmingActivity(DateTime date, double time, double laps) : base(date, time)
    {
        _laps = laps;
    }

    // methods
    public override double CalcDistance()
    {
        return _laps * 50 / 1609;
    }

    public override double CalcSpeed()
    {
        return CalcDistance() * 60 / _time;
    }

    public override double CalcPace()
    {
        return _time / CalcDistance();
    }
}
