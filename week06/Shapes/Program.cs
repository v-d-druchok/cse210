using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blu", 54);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("red", 23, 61);
        shapes.Add(rectangle);

        Circle circle = new Circle("green", 9.31);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {

            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}