using System;

public class Rectangle: Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double height, double width): base(color)
    {
        this._length = height;
        this._width = width;
    }
    public override double GetArea()
    {
        return this._width * _length;
    }
}