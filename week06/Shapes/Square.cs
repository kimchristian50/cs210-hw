using System;

public class Square : Shape
{
    // attribute
    private double _side;

    // constructor
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    // method
    public override double GetArea() // notice the override keyword 
    {
        double area = _side * 2;
        return area;
    }
}