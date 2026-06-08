using System;

public class Rectangle : Shape
{
    // attribute
    private double _length;
    private double _width;

    // constructor
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    // method
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}