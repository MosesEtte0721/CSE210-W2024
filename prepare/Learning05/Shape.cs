using System;

public class Shape 
{

   
    private string _color;

    public Shape(string color)
    {
        this._color = color;
    }

    public void SetColor(string color)
    {

    }

    public string GetColor()
    {
        return this._color;
    }

    public virtual double GetArea()
    {
        return 4;
    }
}