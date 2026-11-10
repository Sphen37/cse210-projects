using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];
        shapes.Add(new Square("green", 20));
        shapes.Add(new Rectangle("purple", 10, 3));
        shapes.Add(new Circle("red", 12));

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The color is {color}.");
            Console.WriteLine($"The area of the shape is {area}");
        }
        
    }
}