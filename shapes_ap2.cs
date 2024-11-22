using System;

abstract class Shape
{
    // Base class for shapes
    public abstract double Area();
    public abstract double Perimeter();
}

class Rectangle : Shape
{
    private double Length { get; }
    private double Width { get; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double Area()
    {
        return Length * Width;
    }

    public override double Perimeter()
    {
        return 2 * (Length + Width);
    }
}

class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Triangle : Shape
{
    private double Side1 { get; }
    private double Side2 { get; }
    private double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override double Area()
    {
        double s = Perimeter() / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }

    public override double Perimeter()
    {
        return Side1 + Side2 + Side3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var rect = new Rectangle(10, 5);
        Console.WriteLine($"Rectangle Area: {rect.Area()}");
        Console.WriteLine($"Rectangle Perimeter: {rect.Perimeter()}");

        var circle = new Circle(7);
        Console.WriteLine($"\nCircle Area: {circle.Area()}");
        Console.WriteLine($"Circle Perimeter: {circle.Perimeter()}");

        var triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"\nTriangle Area: {triangle.Area()}");
        Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter()}");
    }
}
