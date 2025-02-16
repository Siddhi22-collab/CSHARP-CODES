using System.Drawing;

// Basic Shape Class Example 
public class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public Color Color { get; set; }

    public virtual void Draw(Graphics g)
    {
        // Placeholder for drawing logic, should be implemented in derived classes
    }
}

// Derived Class for Rectangle 
public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; } 

    public override void Draw(Graphics g)
    {
        using (Brush brush = new SolidBrush(Color))
        {
            g.FillRectangle(brush, X, Y, Width, Height);
        }
    }
}