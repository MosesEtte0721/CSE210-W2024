using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        
        List<Shape> shapeList = new List<Shape>();
        Square square =  new Square("RED", 47);
        Rectangle rectangle = new Rectangle("Black", 41.7, 34);
        Circle circle = new Circle("GRENN", 34);

        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        // Console.WriteLine($"The color of your rectangle is: {rectangle.GetColor()}");
        // Console.WriteLine($"The area of your Rectangle is: {rectangle.GetArea()}");
        // Console.WriteLine();

        // Console.WriteLine($"The Color of Your Circle is: {circle.GetColor()}");
        // Console.WriteLine($"The Area of Your Circle is: {circle.GetArea()}");

        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape item in shapeList)
        {
            Console.WriteLine($"The {item.GetColor()} shape has an area of {item.GetArea()}");
        
        }
        {
            
        }
    }
}