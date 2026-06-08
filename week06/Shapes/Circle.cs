using System;

public class Circle : Shape
{
    // attribute
    private double _radius;

    // constructor
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    // method
    public override double GetArea()
    {
        double area = _radius * 2 * Math.PI;
        return area;
    }
}