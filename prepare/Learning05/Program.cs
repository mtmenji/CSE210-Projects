using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 5);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("blue", 5, 20);
        shapes.Add(rectangle);
        Circle circle = new Circle("blue", 5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            string polygon = shape.GetShape();
            Console.WriteLine($"The {color} {polygon} has an area of {area}.");
        }
    }
}