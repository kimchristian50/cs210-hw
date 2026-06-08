using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square(10, "blue");
        Console.WriteLine($"Square area is {sq.GetArea()} and it is {sq.GetColor()}");

        Rectangle r = new Rectangle(2, 4, "red");
        Console.WriteLine($"Rectangle area is {r.GetArea()} and it is {r.GetColor()}");

        Circle c = new Circle(10, "red");
        Console.WriteLine($"Circle area is {c.GetArea()} and it is {c.GetColor()}");

        List<Shape> shapes = new List<Shape>(); // initialize a new list with a data type of Shape
        shapes.Add(sq);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape area is {shape.GetArea()} and it is {shape.GetColor()}");
        }

    }
}