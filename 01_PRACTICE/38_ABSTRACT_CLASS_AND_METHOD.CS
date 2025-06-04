using System;

abstract class Shape
{
    public string Color { get; set; }

    // Abstract method
    public abstract double CalculateArea();

    // Concrete method
    public void DisplayColor()
    {
        Console.WriteLine($"Shape Color: {Color}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5, "Red");
        circle.DisplayColor();
        Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");

        Shape rectangle = new Rectangle(4, 6, "Blue");
        rectangle.DisplayColor();
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():F2}");
    }
}
