using System;

public abstract class Activity
{
    // attributes
    protected DateTime _date;
    protected double _time;

    // constructor
    public Activity(DateTime date, double time)
    {
        _date = date;
        _time = time;
    }

    // methods
    public abstract double CalcDistance();

    public abstract double CalcSpeed();

    public abstract double CalcPace();

    public string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        string activityType = GetType().Name.Replace("Activity", ""); // edit the activity name to get the appropriate Running, Swimming, or Cycling

        string summary = $"{formattedDate} {activityType} ({_time} minutes) - Distance {CalcDistance():0.0} miles, Speed {CalcSpeed():0.0} mph, Pace {CalcPace():0.0} min/mile";
        return summary;
    }
}