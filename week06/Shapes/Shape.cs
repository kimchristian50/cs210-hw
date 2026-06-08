using System;
using System.Drawing;

public abstract class Shape
{
    // attribute
    private string _color;

    // constructor
    public Shape(string color)
    {
        _color = color;
    }

    // methods
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}